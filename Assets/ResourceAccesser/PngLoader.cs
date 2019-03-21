using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;

namespace Assets.ResourceAccesser
{
    public class PngLoader
    {
        public Texture2D ReadByBinary(byte[] bytes)
        {
            // そのまま使わないならサイズ適当でOK.
            Texture2D texture = new Texture2D(1, 1);
            texture.LoadImage(bytes);
            return texture;
        }

        public byte[] ReadPngFile(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryReader bin = new BinaryReader(fileStream);
                byte[] values = bin.ReadBytes((int)bin.BaseStream.Length);
                bin.Close();
                return values;
            }
        }
    }
}
