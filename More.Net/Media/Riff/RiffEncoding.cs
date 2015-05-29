using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Media
{
    /// <summary>
    /// Resource Interchange File Format
    /// </summary>
    public class RiffEncoding
    {
        public static Byte[] GetBytes(Int32 sampleRate, Double[] data)
        {
            Int32 bitsPerSample;
            Byte[] byteData;
            Int32 byteDataLength;
            Int32 byteRate;
            Int32 dataElementTypeSize;
            Byte[] encodedBytes;
            Int32 numchannels;
            Int32 subChunk1Size;
            Int32 subChunk2Size;

            dataElementTypeSize = 8;
            numchannels = 1;
            bitsPerSample = dataElementTypeSize * BitsPerByte;
            byteRate = sampleRate * dataElementTypeSize * numchannels;
            byteDataLength = data.Length * dataElementTypeSize * numchannels;
            subChunk1Size = 16;
            subChunk2Size = byteDataLength;

            byteData = new Byte[byteDataLength];
            Buffer.BlockCopy(data, 0, byteData, 0, byteData.Length);

            using (MemoryStream ms = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(ms))
            {
                writer.Write(Encoding.UTF8.GetBytes("RIFF"));
                writer.Write((UInt32)(4 + (subChunk1Size + 8) + (subChunk2Size + 8) + (4 + 8)));
                writer.Write(Encoding.UTF8.GetBytes("WAVE"));
                writer.Write(Encoding.UTF8.GetBytes("fmt "));
                writer.Write((UInt32)subChunk1Size);
                writer.Write((UInt16)0x0003);
                writer.Write((UInt16)numchannels);
                writer.Write((UInt32)sampleRate);
                writer.Write((UInt32)byteRate);
                writer.Write((UInt16)dataElementTypeSize);
                writer.Write((UInt16)bitsPerSample);
                writer.Write((UInt16)0);
                writer.Write(Encoding.UTF8.GetBytes("fact"));
                writer.Write((UInt32)4);
                writer.Write((UInt32)data.GetLength(0));
                writer.Write(Encoding.UTF8.GetBytes("data"));
                writer.Write((UInt32)subChunk2Size);
                writer.Write(byteData);
                encodedBytes = ms.ToArray();
            }

            return encodedBytes;
        }

        private const Int32 BitsPerByte = 8;
    }
}