#define CVR_SCRIPTING_ENVIRONMENT

using System;
using System.Runtime.CompilerServices;
using System.Text;

#if !CVR_SCRIPTING_ENVIRONMENT
using Unity.Collections.LowLevel.Unsafe;
using System.Runtime.InteropServices;
#endif

namespace WasmScripting {
	/// <summary>
	/// This is intended for the low level Networking API to assist with reading and writing messages efficiently
	/// </summary>
	public ref partial struct BufferReaderWriter {
		private Span<byte> _buffer;
		private int _position;
		private int _length;

		public Span<byte> Buffer => _buffer;

		public int Length => _length;

		public int Position {
			get => _position;
			set => _position = value;
		}

		public BufferReaderWriter(int initialCapacity = 64) {
			_buffer = new byte[initialCapacity];
			_position = 0;
			_length = 0;
		}

		public BufferReaderWriter(byte[] data) {
			_buffer = data;
			_position = 0;
			_length = data.Length;
		}

		public BufferReaderWriter(Span<byte> data) {
			_buffer = data;
			_position = 0;
			_length = data.Length;
		}

		public void Write<T>(ReadOnlySpan<T> value, bool writeLength = true) where T : unmanaged {
			if (writeLength) Write(value.Length);
			int size = SizeOf<T>() * value.Length;
			EnsureCapacity(size);
			Copy(value, _buffer[_position..]);
			_position += size;
			if (_position > _length) _length = _position;
		}

		public void Write<T>(T[] value, bool writeLength = true) where T : unmanaged {
			if (writeLength) Write(value.Length);
			int size = SizeOf<T>() * value.Length;
			EnsureCapacity(size);
			Copy<T, byte>(value, _buffer[_position..]);
			_position += size;
			if (_position > _length) _length = _position;
		}
		
		public void Write<T>(T value) where T : unmanaged {
			int size = SizeOf<T>();
			EnsureCapacity(size);
			Write(_buffer[_position..(_position + size)], ref value);
			_position += size;
			if (_position > _length) _length = _position;
		}
		
		public void Write(string value, Encoding encoding = null, bool writeLength = true) {
			encoding ??= Encoding.UTF8;
			byte[] bytes = encoding.GetBytes(value);
			if (writeLength) Write(bytes.Length);
			EnsureCapacity(bytes.Length);
			Copy<byte, byte>(bytes, _buffer[_position..]);
			_position += bytes.Length;
			if (_position > _length) _length = _position;
		}

		/// <summary>
		/// Special method to write a UTF16 string faster than using the regular write version
		/// </summary>
		public void WriteStringFast(string value, bool writeLength = true) {
			int length = value.Length * sizeof(char);
			if (writeLength) Write(length);
			EnsureCapacity(length);
			AsBytes(value.AsSpan()).CopyTo(_buffer[_position..]);
			_position += length;
			if (_position > _length) _length = _position;
		}

		public void Read<T>(out Span<T> value) where T : unmanaged {
			Read(out int length);
			Read(out value, length);
		}
		
		public void Read<T>(out Span<T> value, int length) where T : unmanaged {
			int size = SizeOf<T>() * length;
			if (_position + size > _length)
				throw new IndexOutOfRangeException($"Error Reading Value. Index of `{_position + size}` is outside the bounds of array of length `{_buffer.Length}`.");
			value = Cast<byte, T>(_buffer[_position..(_position + size)]);
			_position += size;
		}

		public void Read<T>(out T[] value) where T : unmanaged {
			Read(out int length);
			Read(out value, length);
		}
		
		public void Read<T>(out T[] value, int length) where T : unmanaged {
			int size = SizeOf<T>() * length;
			if (_position + size > _length)
				throw new IndexOutOfRangeException($"Error Reading Value. Index of `{_position + size}` is outside the bounds of array of length `{_buffer.Length}`.");
			value = new T[length];
			Copy<byte, T>(_buffer[_position..(_position + size)], value.AsSpan());
			_position += size;
		}
		
		public void Read<T>(out T value) where T : unmanaged {
			int size = SizeOf<T>();
			if (_position + size > _length)
				throw new IndexOutOfRangeException($"Error Reading Value. Index of `{_position + size}` is outside the bounds of array of length `{_buffer.Length}`.");
			value = Read<T>(_buffer[_position..(_position + size)]);
			_position += size;
		}

		public void Read(out string value, Encoding encoding = null) {
			Read(out int length);
			Read(out value, length, encoding);
		}

		public void Read(out string value, int size, Encoding encoding = null) {
			encoding ??= Encoding.UTF8;
			if (_position + size > _length)
				throw new IndexOutOfRangeException($"Error Reading Value. Index of `{_position + size}` is outside the bounds of array of length `{_buffer.Length}`.");
			value = encoding.GetString(_buffer[_position..(_position + size)]);
			_position += size;
		}

		/// <summary>
		/// Special method to read a UTF16 string faster than using the regular read version
		/// </summary>
		public void ReadStringFast(out string value) {
			Read(out int length);
			ReadStringFast(out value, length);
		}

		/// <summary>
		/// Special method to read a UTF16 string faster than using the regular read version
		/// </summary>
		public void ReadStringFast(out string value, int length) {
			int size = length * sizeof(char);
			if (_position + size > _length)
				throw new IndexOutOfRangeException($"Error Reading Value. Index of `{_position + size}` is outside the bounds of array of length `{_buffer.Length}`.");
			value = new string(Cast<byte, char>(_buffer[_position..(_position + size)]));
			_position += size;
		}

		private void EnsureCapacity(int additionalBytes) {
			if (_position + additionalBytes <= _buffer.Length) return;
			int newSize = Math.Max(_buffer.Length * 2, _position + additionalBytes);
			byte[] newBuffer = new byte[newSize];
			Copy<byte, byte>(_buffer, newBuffer);
			_buffer = newBuffer;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static T Read<T>(Span<byte> span) where T : unmanaged {
#if CVR_SCRIPTING_ENVIRONMENT
			unsafe {
				fixed (byte* pSrc = span) return *(T*)pSrc;
			}
#else
			return MemoryMarshal.Read<T>(span);
#endif
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Write<T>(Span<byte> span, ref T value) where T : unmanaged {
#if CVR_SCRIPTING_ENVIRONMENT
			unsafe {
				fixed (byte* p = span) *(T*)p = value;
			}
#else
			MemoryMarshal.Write(span, ref value);
#endif
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) where T : unmanaged {
#if CVR_SCRIPTING_ENVIRONMENT
			unsafe {
				fixed (T* pSrc = span) return new(pSrc, span.Length * SizeOf<T>());
			}
#else
			return MemoryMarshal.AsBytes(span);
#endif
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) where TFrom : unmanaged where TTo : unmanaged {
#if CVR_SCRIPTING_ENVIRONMENT
			unsafe {
				fixed (TFrom* pSrc = span) return new Span<TTo>(pSrc, span.Length * SizeOf<TFrom>() / SizeOf<TTo>());
			}
#else
			return MemoryMarshal.Cast<TFrom, TTo>(span);
#endif
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int SizeOf<T>() where T : unmanaged {
#if CVR_SCRIPTING_ENVIRONMENT
			return Unsafe.SizeOf<T>();
#else
			return UnsafeUtility.SizeOf<T>();
#endif
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Copy<TFrom, TTo>(ReadOnlySpan<TFrom> src, Span<TTo> dst) where TFrom : unmanaged where TTo : unmanaged {
#if CVR_SCRIPTING_ENVIRONMENT
			unsafe {
				fixed (void* pSrc = src)
				fixed (void* pDst = dst) {
					System.Buffer.MemoryCopy(pSrc, pDst, dst.Length * Unsafe.SizeOf<TTo>(), src.Length * Unsafe.SizeOf<TFrom>());
				}
			}
#else
			MemoryMarshal.AsBytes(src).CopyTo(MemoryMarshal.AsBytes(dst));
#endif
		}
	}
}