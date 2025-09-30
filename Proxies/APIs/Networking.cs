using System.Runtime.InteropServices;
using WasmScripting;

namespace CVR;

public static class Networking {
	public delegate void OnReceiveMessageEvent(Player sender, Span<byte> message);
	
	public static OnReceiveMessageEvent OnReceiveMessage;
	
	public static void SendMessage(BufferReaderWriter writer, short[] playerIds = null, SendType sendType = SendType.Unreliable, bool loopback = false) 
		=> SendMessage(writer.Buffer, playerIds, sendType, loopback);
	
	public static unsafe void SendMessage(Span<byte> message, short[] playerIds = null, SendType sendType = SendType.Unreliable, bool loopback = false) {
		fixed (byte* messagePtr = message)
		fixed (short* playerIdsPtr = playerIds) {
			CVR_Networking_SendMessage(messagePtr, message.Length, playerIdsPtr, playerIds?.Length ?? 0, sendType);
		}
		if (loopback) OnReceiveMessage?.Invoke(LocalPlayer.PlayerObject, message);
	}

	public static bool WillMessageBeDropped(int messageSize) => CVR_Networking_WillMessageBeDropped(messageSize) != 0;
	
	public static float NetworkCloggedPercentage() => CVR_Networking_NetworkCloggedPercentage();
	
	public static int Ping => CVR_Networking_GetPing();
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern unsafe void CVR_Networking_SendMessage(byte* messagePtr, int messageLength, short* playerIdsPtr, int playerIdsLength, SendType sendType);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern int CVR_Networking_WillMessageBeDropped(int messageSize);
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern float CVR_Networking_NetworkCloggedPercentage();
	
	[WasmImportLinkage, DllImport("CVR")]
	private static extern int CVR_Networking_GetPing();
	
	public enum SendType {
		Unreliable,
		UnreliableSequenced,
		Reliable,
	}
}