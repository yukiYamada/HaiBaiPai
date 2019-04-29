using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.BaseObject
{
    public class CustomSprite
    {
        public Sprite ToSprite{get; private set;}
        public CustomSprite(QuestionResourcePath pngDirectoryPath)
        {

            this.ToSprite = ResourceAccesser.PngConvertToSprite.Convert(pngDirectoryPath.SpritePath);
        }

    }
}
