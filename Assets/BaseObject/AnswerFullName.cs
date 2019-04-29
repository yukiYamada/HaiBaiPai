using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.BaseObject
{
    public class AnswerFullName
    {
        public readonly string Value;
        public AnswerFullName(QuestionResourcePath resourcePath)
        {
            Value = resourcePath.AnswerFullName;
        }
    }
}
