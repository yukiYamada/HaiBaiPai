using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Assets.ResourceAccesser;

namespace Assets.GameMain
{
    public class Loader : MonoBehaviour {
        // Use this for initialization
        void Start() {
            var loader = new PngLoader();
            Texture2D texture = loader.ReadByBinary(loader.ReadPngFile("Assets/2DResources/Questions/hai/hihat/main.png"));

            // Spriteの場合はGetComponent<SpriteRenderer>
            SpriteRenderer renderer = this.GetComponent<SpriteRenderer>();

            //renderer.material.mainTexture = texture;
            renderer.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 2500);
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
