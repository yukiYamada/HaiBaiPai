using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.BaseObject
{
    public class QuestionResource : IQuestion
    {
        public QuestionResourcePath PngDirectoryPath { get; private set;}

        public QuestionResource(QuestionResourcePath path)
        {
            this.PngDirectoryPath = path;
            this.Answer = new Answer(path);
            this.Sprite = new CustomSprite(path);
            this.AnswerFullName = new AnswerFullName(path);

        }

        public Answer Answer { get; private set;}
        public Hint Hint { get; private set;}
        public CustomSprite Sprite { get; private set; }
        public AnswerFullName AnswerFullName { get; private set; }
    }
}
