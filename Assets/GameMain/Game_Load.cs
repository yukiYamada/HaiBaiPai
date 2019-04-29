using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Assets.ResourceAccesser;
using Assets.Questions;
using Assets.BaseObject;

namespace Assets.GameMain
{
    public class Game_Load : MonoBehaviour {
        // Use this for initialization
        void Start() {
            var game = new GameControl();
            game.ReadOneQuestion();                        
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
