﻿using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;
using System;
using Assets.ResourceAccesser;

namespace Editor.GameMain
{
    public class LoaderTest
    {
        [Test]
        public void ReadPngFile()
        {
            var loader = new PngLoader();
            var ts = loader.ReadPngFile("Assets/2DResources/Questions/hai/hihat/main.png");
            Assert.IsNotNull(ts, "画像ファイルのロードの失敗");
        }
    }
}
