using System;
using System.IO;
using SecureSocketProtocol3;
using System.Collections.Generic;

namespace LiteCode_Client
{
    public class ClientProps : ClientProperties
    {

        public override string HostIp
        {
            get { return "127.0.0.1"; }
        }

        public override ushort Port
        {
            get { return 444; }
        }

        public override int ConnectionTimeout
        {
            get { return 15000; }
        }

        public override string Username
        {
            get { return "username";  }
        }

        public override string Password
        {
            get { return "password"; }
        }


        public override byte[] NetworkKey
        {
            get
            {
                return new byte[]
                {
                        80, 118, 131, 114, 195, 224, 157, 246, 141, 113,
                        186, 243, 77, 151, 247, 84, 70, 172, 112, 115,
                        112, 110, 91, 212, 159, 147, 180, 188, 143, 251,
                        218, 155
                };
            }
        }
        public override System.Drawing.Size Handshake_Maze_Size
        {
            get { return new System.Drawing.Size(128, 128); }
        }

        public override ushort Handshake_StepSize
        {
            get { return 5; }
        }

        public override ushort Handshake_MazeCount
        {
            get { return 1; }
        }

        public override uint Cipher_Rounds
        {
            get { return 100; }
        }

        public override EncAlgorithm EncryptionAlgorithm
        {
            get { return EncAlgorithm.HwAES; }
        }

        public override CompressionAlgorithm CompressionAlgorithm
        {
            get { return CompressionAlgorithm.QuickLZ; }
        }

        public override Stream[] PrivateKeyFiles
        {
            get
            {
                List<MemoryStream> keys = new List<MemoryStream>();
                keys.Add(new MemoryStream(Properties.Resources.PrivateKey1));
                keys.Add(new MemoryStream(Properties.Resources.PrivateKey2));
                return keys.ToArray();
            }
        }

        public override Stream PublicKeyFile
        {
            get
            {
                return new MemoryStream(Properties.Resources.PublicKey);
            }
        }
    }
}