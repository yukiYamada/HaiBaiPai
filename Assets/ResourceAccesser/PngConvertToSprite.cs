using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;

namespace Assets.ResourceAccesser
{
    public static class PngConvertToSprite
    {
        private static Texture2D byteConvertToTexture2D(byte[] bytes)
        {
            // そのまま使わないならサイズ適当でOK.
            Texture2D texture = new Texture2D(1, 1);
            texture.LoadImage(bytes);
            return texture;
        }

        private static byte[] ReadPngFile(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryReader bin = new BinaryReader(fileStream);
                byte[] values = bin.ReadBytes((int)bin.BaseStream.Length);
                bin.Close();
                return values;
            }
        }

        public static Sprite Convert(string pngPath)
        {
            Texture2D texture = byteConvertToTexture2D(ReadPngFile(pngPath));
            return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 480);
        }
    }
}
