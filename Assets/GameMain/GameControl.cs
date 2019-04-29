using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.BaseObject;
using UnityEngine;
using Assets.ResourceAccesser;
using UnityEngine.UI;

namespace Assets.GameMain
{
    public class GameControl
    {
        private static QuestionResources _questions;

        public GameControl()
        {
            _questions = new QuestionResources("Assets/2DResources/Questions/");
        }

        private SpriteRenderer MainSpriteRender
        {
            get
            {
                var obj = GameObject.Find("Question");
                SpriteRenderer renderer = obj.GetComponent<SpriteRenderer>();
                return renderer;
            }
        } 

        public void ReadOneQuestion()
        {
            MainSpriteRender.sprite = _questions.SelectOne().Sprite.ToSprite;
        }

        public void JudgeAnswer(InputField field)
        {
            if (string.IsNullOrEmpty(field.text))
            {
                return;
            }
            switch (_questions.Selected.Answer.Judge(field.text))
            {
                case JudgmentResultType.NG:
                    MainSpriteRender.sprite = _questions.SelectOne().Sprite.ToSprite;
                    field.text = "";
                    break;
                case JudgmentResultType.MatchPerfect: 
                    MainSpriteRender.sprite = _questions.SelectOne().Sprite.ToSprite;
                    field.text = "";
                    break;
                case JudgmentResultType.MatchForward:
                    break;
            }
        }
    }
}
