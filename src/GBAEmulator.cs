using System.Runtime.InteropServices;
using CVR;
using OptimeGBA;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using WasmScripting;

public unsafe partial class GBAEmulator : WasmBehaviour {
    private const int CpuHz = 16777216;
    private const int Width = 240, Height = 160;

    private static GBAEmulator _instance;
    private static Gba _gba;
    private static Texture2D _screen;
    private static uint* _frameBuffer;
    private static double _fpsEvalTimer;
    private static double _nextFrameAt;
    private static int _cyclesLeft;
    private static long _cyclesRan;
    private static double _fps;
    private static double _ips;
    private static bool _quit;
    private static bool _resetDue;
    private static bool _viewRam;
    private static bool _immobilized;
    
    public Material Material;
    public AudioClip AudioClip;
    public AudioSource AudioSource;
    public TMP_Text PerformanceInfo;

    private void Start() {
        Debug.Log("[Optime GBA] Starting");
        
        _instance = this;
        
        _screen = new(Width, Height, GraphicsFormat.R8G8B8A8_SRGB, TextureCreationFlags.None) { filterMode = FilterMode.Point };
        _frameBuffer = (uint*)Marshal.AllocHGlobal(Width * Height * sizeof(uint));
        Material.mainTexture = _screen;
        
        try {
            Reload();
        } catch (Exception e) {
            Debug.LogError($"[Optime GBA] {e}");
        }
    }

    private void FixedUpdate() {
        if (_quit) return;

        if (Input.GetKeyDown(KeyCode.P)) {
            _immobilized = !_immobilized;
            LocalPlayer.SetImmobilized(_immobilized);
        }

        if (_immobilized) {
            _gba.Keypad.A = Input.GetKey(KeyCode.F);
            _gba.Keypad.B = Input.GetKey(KeyCode.G);
            _gba.Keypad.Select = Input.GetKey(KeyCode.Backspace);
            _gba.Keypad.Start = Input.GetKey(KeyCode.Return);
            _gba.Keypad.Left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
            _gba.Keypad.Right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
            _gba.Keypad.Up = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
            _gba.Keypad.Down = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
            _gba.Keypad.L = Input.GetKey(KeyCode.Q);
            _gba.Keypad.R = Input.GetKey(KeyCode.E);
            _resetDue = Input.GetKey(KeyCode.Insert);
        }
        
        
        if (Input.GetKey(KeyCode.F2)) _gba.Ppu.Renderer.DebugEnableRendering = !_gba.Ppu.Renderer.DebugEnableRendering;
        if (Input.GetKey(KeyCode.F3)) _gba.GbaAudio.DebugEnableA = !_gba.GbaAudio.DebugEnableA;
        if (Input.GetKey(KeyCode.F4)) _gba.GbaAudio.DebugEnableB = !_gba.GbaAudio.DebugEnableB;
        if (Input.GetKey(KeyCode.F5)) _gba.GbaAudio.GbAudio.enable1Out = !_gba.GbaAudio.GbAudio.enable1Out;
        if (Input.GetKey(KeyCode.F6)) _gba.GbaAudio.GbAudio.enable2Out = !_gba.GbaAudio.GbAudio.enable2Out;
        if (Input.GetKey(KeyCode.F7)) _gba.GbaAudio.GbAudio.enable3Out = !_gba.GbaAudio.GbAudio.enable3Out;
        if (Input.GetKey(KeyCode.F8)) _gba.GbaAudio.GbAudio.enable4Out = !_gba.GbaAudio.GbAudio.enable4Out;
        if (Input.GetKey(KeyCode.LeftBracket)) {
            if (_gba.GbaAudio.GbAudio.PsgFactor > 0)
                _gba.GbaAudio.GbAudio.PsgFactor--;
        }
        if (Input.GetKey(KeyCode.RightBracket)) _gba.GbaAudio.GbAudio.PsgFactor++;
        if (Input.GetKey(KeyCode.F9)) _gba.GbaAudio.Resample = !_gba.GbaAudio.Resample;
        if (Input.GetKey(KeyCode.F10)) _viewRam = !_viewRam;
        

        double currentSec = Time.realtimeSinceStartupAsDouble;

        if (_resetDue) {
            _resetDue = false;
            byte[] save = _gba.Mem.SaveProvider.GetSave();
            ProviderGba p = _gba.Provider;
            _gba = new Gba(p);
            _gba.Mem.SaveProvider.LoadSave(save);

            _nextFrameAt = currentSec;
        }

        //if (currentSec - _nextFrameAt >= SecondsPerFrameGba) {
        //    double diff = currentSec - _nextFrameAt;
        //    Debug.Log($"[Optime GBA] Can't keep up! Skipping {(int)(diff * 1000)} milliseconds");
        //    _nextFrameAt = currentSec;
        //}

        if (currentSec >= _nextFrameAt) {
            int frameCycles = (int)(CpuHz * Time.fixedDeltaTime);
            _nextFrameAt += 1d / ((double)CpuHz / frameCycles);
            try {
                _cyclesLeft += frameCycles;
                _cyclesRan += frameCycles;
                while (_cyclesLeft > 0) _cyclesLeft -= (int)_gba.StateStep();
            } catch (Exception e) {
                Debug.LogError($"[Optime GBA] {e}");
                _quit = true;
                return;
            }

            ushort* screenFront = _gba.Ppu.Renderer.ScreenFront;
            for (int i = 0; i < Width * Height; i++) {
                ushort c = screenFront[i];
                int r5 = c & 0x1F;
                int g5 = (c >> 5) & 0x1F;
                int b5 = (c >> 10) & 0x1F;
            
                int r8 = (r5 << 3) | (r5 >> 2);
                int g8 = (g5 << 3) | (g5 >> 2);
                int b8 = (b5 << 3) | (b5 >> 2);
            
                _frameBuffer[i] = (uint)(0xFF << 24 | b8 << 16 | g8 << 8 | r8);
            }

            if (_viewRam) {
                fixed(void* ramPtr = _gba.Mem.Iwram)
                    UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemVoid(_screen.WrappedId, ramPtr, Width * Height);
            } else UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemVoid(_screen.WrappedId, _frameBuffer, Width * Height);
            
            _screen.Apply();
        }

        if (currentSec >= _fpsEvalTimer) {
            double diff = currentSec - _fpsEvalTimer + 5;
            double frames = _cyclesRan / 280896D;
            _cyclesRan = 0;

            double ips = _gba.Cpu.InstructionsRan;
            _gba.Cpu.InstructionsRan = 0;

            _fps = Math.Floor(frames / diff * 100) / 100;
            _ips = Math.Floor(ips / diff);

            _fpsEvalTimer += 1;
            
            PerformanceInfo.text = $"[Optime GBA] FPS: {_fps}, IPS: {_ips}";
        }

        if (_gba.Mem.SaveProvider.Dirty) {
            _gba.Mem.SaveProvider.Dirty = false;
            try {
                FileStorage.WriteFile(_gba.Provider.SavPath, _gba.Mem.SaveProvider.GetSave());
            } catch (Exception e) {
                Debug.LogError($"[Optime GBA] Failed to write .sav file! ({e.Message})");
            }
        }
    }

    private static void Reload() {
        const string biosPath = "gba_bios.bin";
        const string romPath = "game.gba";
        
        if (!FileStorage.FileExists(romPath)) {
            Debug.Log("[Optime GBA] The ROM file you provided does not exist.");
            _quit = true;
            return;
        }
        
        CVRFile romFile = FileStorage.ReadFile(romPath);
        
        Debug.Log(romFile == null);
        Debug.Log(romFile!._bytes == null);
        byte[] rom = romFile.Bytes.ToArray();

        if (!FileStorage.FileExists(biosPath)) {
            Debug.LogError("[Optime GBA] Please place a valid GBA BIOS named \"gba_bios.bin\" which has been properly modified in the local storage for this world");
            _quit = true;
            return;
        }
        
        byte[] bios = FileStorage.ReadFile(biosPath).Bytes.ToArray();

        string savPath = romPath.Substring(0, romPath.Length - 4) + ".sav";
        byte[] sav = [];

        if (FileStorage.FileExists(savPath)) {
            Debug.Log("[Optime GBA] .sav exists, loading");
            sav = FileStorage.ReadFile(savPath).Bytes.ToArray();
        } else {
            Debug.Log("[Optime GBA] .sav not available");
        }

        _gba = new(new(bios, rom, savPath, AudioReady) { BootBios = true });

        _gba.Mem.SaveProvider.LoadSave(sav);

        double time = Time.realtimeSinceStartupAsDouble;
        _nextFrameAt = time;
        _fpsEvalTimer = time;
    }
    
    private static void AudioReady(float[] data) {
        _instance.AudioClip.SetData(data, 0);
        _instance.AudioSource.Play();
    }
    
    [WasmImportLinkage, DllImport("UnityEngine")]
    private static extern void UnityEngineTexture2D__func__SetPixels32__UnityEngineColor32Array__SystemVoid(long selfObjectId, void* colorsPointer, int colorsWasmLength);
}