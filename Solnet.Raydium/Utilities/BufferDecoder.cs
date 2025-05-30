﻿using Solnet.Raydium.Models.Layouts;
using Solnet.Wallet;
using Solnet.Wallet.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Solnet.Raydium.Utilities
{
    /// <summary>
    /// Utility class for decoding byte buffers
    /// </summary>
    public class BufferDecoder
    {
        /// <summary>
        /// Length of the byte buffer.
        /// </summary>
        private int Length { get; }

        /// <summary>
        /// Current read position.
        /// </summary>
        public int Cursor { get; set; }

        /// <summary>
        /// The internal buffer.
        /// </summary>
        private byte[] _buffer;

        /// <summary>
        /// Constructs a buffer decode with the given byte buffer.
        /// </summary>
        /// <param name="buffer"></param>
        public BufferDecoder(byte[] buffer) 
        {
            _buffer = buffer ?? throw new ArgumentNullException(nameof(buffer));
            Cursor = 0;
            Length = buffer.Length;
        }

        /// <summary>
        /// Decodes a Base64 data string into bytes and returns a BufferDecoder initialized with the decoded buffer.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>An instance of the BufferDecoder initialized with the decoded base 64 string.</returns>
        public static BufferDecoder CreateFromBase64(string data)
        {
            byte[] buffer = Convert.FromBase64String(data ?? throw new ArgumentNullException(nameof(data)));
            return new BufferDecoder(buffer);
        }

        /// <summary>
        /// Decodes a Base58 data string into bytes and returns a BufferDecoder initialized with the decoded buffer.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>An instance of the BufferDecoder initialized with the decoded base 58 string.</returns>
        public static BufferDecoder CreateFromBase58(string data)
        {
            var enc = new Base58Encoder();
            byte[] buffer = enc.DecodeData(data ?? throw new ArgumentNullException(nameof(data)));
            return new BufferDecoder(buffer);
        }

        /// <summary>
        /// Reads one byte from the buffer and advances the cursor position.
        /// </summary>
        /// <returns>The byte read.</returns>
        public byte ReadByte()
        {
            if (Cursor >= Length) throw new ApplicationException("Buffer exhausted");
            byte value = _buffer[Cursor];
            Cursor += 1;
            return value;
        }

        public byte ReadByte(int index)
        {
            if (index >= Length) throw new ApplicationException("Buffer exhausted");
            byte value = _buffer[index];
            
            return value;
        }

        /// <summary>
        /// Reads one byte from the buffer and advances the cursor position.
        /// </summary>
        /// <returns>The byte read.</returns>
        public Span<byte> ReadBytes(int bytesToRead)
        {
            if ((Cursor + bytesToRead) > Length) throw new ApplicationException("Buffer exhausted");
            var span = _buffer.AsSpan(Cursor, bytesToRead);
            Cursor += bytesToRead;
            return span;
        }

        public Span<byte> ReadBytes(int bytesToRead, int index)
        {
            if ((index + bytesToRead) > Length) throw new ApplicationException("Buffer exhausted");
            var span = _buffer.AsSpan(index, bytesToRead);
            
            return span;
        }

        /// <summary>
        /// Reads a PublicKey from the buffer and advances the cursor position.
        /// </summary>
        /// <returns>A PublicKey instance.</returns>
        public PublicKey ReadPublicKey()
        {
            if ((Cursor + 32) > Length) throw new ApplicationException("Buffer exhausted");
            var pubkey = new PublicKey(_buffer.AsSpan(Cursor, 32));
            Cursor += 32;
            return pubkey;
        }

        public PublicKey ReadPublicKey(int index)
        {
            if ((index + 32) > Length) throw new ApplicationException("Buffer exhausted");
            var pubkey = new PublicKey(_buffer.AsSpan(index, 32));
            
            return pubkey;
        }

        /// <summary>
        /// Reads a uint from the buffer and advances the cursor position.
        /// </summary>
        /// <returns>A uint value read from the buffer.</returns>
        public ushort ReadU16(int index)
        {
            if ((index + 2) > Length) throw new ApplicationException("Buffer exhausted");
            var value = BitConverter.ToUInt16(_buffer, index);
            return value;
        }


        /// <summary>
        /// Reads a uint from the buffer and advances the cursor position.
        /// </summary>
        /// <returns>A uint value read from the buffer.</returns>
        public uint ReadU32()
        {
            if ((Cursor + 4) > Length) throw new ApplicationException("Buffer exhausted");
            var value = BitConverter.ToUInt32(_buffer, Cursor);
            Cursor += 4;
            return value;
        }

        /// <summary>
        /// Reads a uint from the buffer and advances the cursor position.
        /// </summary>
        /// <returns>A uint value read from the buffer.</returns>
        public uint ReadU32(int index)
        {
            if ((index + 4) > Length) throw new ApplicationException("Buffer exhausted");
            var value = BitConverter.ToUInt32(_buffer, index);
            return value;
        }

        /// <summary>
        /// Reads a ulong from the buffer and advances the cursor position.
        /// </summary>
        /// <returns>An ulong value read from the buffer.</returns>
        public ulong ReadU64()
        {
            if ((Cursor + 8) > Length) throw new ApplicationException("Buffer exhausted");
            var value = BitConverter.ToUInt64(_buffer, Cursor);
            Cursor += 8;
            return value;
        }

        public ulong ReadU64(int index)
        {
            if ((index + 8) > Length) throw new ApplicationException("Buffer exhausted");
            var value = BitConverter.ToUInt64(_buffer, index);            
            return value;
        }

        /// <summary>
        /// Reads a PublicKey from the buffer and advances the cursor position.
        /// </summary>
        /// <returns></returns>
        public U128 ReadU128()
        {
            if ((Cursor + 16) > Length) throw new ApplicationException("Buffer exhausted");
            return new U128(ReadBytes(16));
        }

        public U128 ReadU128(int index)
        {
            if ((index + 16) > Length) throw new ApplicationException("Buffer exhausted");
            return new U128(ReadBytes(16, index));
        }

        /// <summary>
        /// Decode the buffer using a type as a layout guide for properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>An instance of the type specified populated with the decoded data properties populated.</returns>
        public T DecodeAs<T>() where T : new()
        {
            var dataType = typeof(T);
            var obj = new T();
            foreach (var prop in dataType.GetProperties())
            {
                if (prop.PropertyType == typeof(ulong))
                {
                    prop.SetValue(obj, ReadU64());
                }
                else if (prop.PropertyType == typeof(PublicKey))
                {
                    prop.SetValue(obj, ReadPublicKey());
                }
                else if (prop.PropertyType == typeof(byte))
                {
                    prop.SetValue(obj, ReadByte());
                }
                else if (prop.PropertyType == typeof(U128))
                {
                    prop.SetValue(obj, ReadU128());
                }
                else
                {
                    throw new NotSupportedException($"Property {prop.Name} type {prop.PropertyType.FullName}");
                }
            }
            return obj;
        }

        /// <summary>
        /// Decode the buffer faster using only properties marked as [Decode] in a type as a layout guide for properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>An instance of the type specified populated with the decoded data properties populated.</returns>
        public T DecodeFastAs<T >() where T : new()
        {
            var dataType = typeof (T);
            var obj = new T();

            var toDecode = (obj is BaseLayout) ? (obj as BaseLayout).GetOffsets() : new Dictionary<PropertyInfo, int>();

            dataType.GetProperties().AsParallel().ForAll(prop =>
            {
                if (!toDecode.TryGetValue(prop, out var ind))
                    return;
                
                if (prop.PropertyType == typeof(ulong))
                {
                    prop.SetValue(obj, ReadU64(ind));
                }
                else if (prop.PropertyType == typeof(PublicKey))
                {
                    prop.SetValue(obj, ReadPublicKey(ind));
                }
                else if (prop.PropertyType == typeof(byte))
                {
                    prop.SetValue(obj, ReadByte(ind));
                }
                else if (prop.PropertyType == typeof(U128))
                {
                    prop.SetValue(obj, ReadU128(ind));
                }
                else if (prop.PropertyType == typeof(UInt32))
                {
                    prop.SetValue(obj, ReadU32(ind));
                }
                else if (prop.PropertyType == typeof(UInt16))
                {
                    prop.SetValue(obj, ReadU16(ind));
                }
                else
                {
                    throw new NotSupportedException($"Property {prop.Name} type {prop.PropertyType.FullName}");
                }
            });

            return obj;
        }

    }

}
