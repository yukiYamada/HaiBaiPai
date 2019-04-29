using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.BaseObject;
using Assets.ResourceAccesser;
namespace Assets.Questions
{
    public abstract class GeneralQuestionBase : MonoBehaviour, IQuestion
    {
        internal readonly QuestionResource _resource;
        public GeneralQuestionBase(QuestionResource resource)
        {
            _resource = resource;
        }
        
        /// <summary>画像本体</summary>
        public CustomSprite Sprite
        {
            get
            {
                return _resource.Sprite;
            }
        }

        /// <summary>回答</summary>
        public Answer Answer
        {
            get
            {
                return _resource.Answer;
            }
        }

        /// <summary>ヒント</summary>
        public Hint Hint
        {
            get
            {
                return _resource.Hint;
            }
        }

        public AnswerFullName AnswerFullName
        {
            get
            {
                return _resource.AnswerFullName;
            }
        }
    }
}
