using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Questions;

namespace Assets.BaseObject
{
    public class Answer : MonoBehaviour
    {
        /// <summary>
        /// haiかpaiかbaiか3.14になるかな。
        /// </summary>
        public readonly string Value;
        public Answer(QuestionResourcePath resourcePath)
        {
            Value = resourcePath.AnswerName;
        }
        
        public JudgmentResultType Judge(string input)
        {
            if(!Value.StartsWith(input))
            {
                return JudgmentResultType.NG;
            }
            if(Value == input)
            {
                return JudgmentResultType.MatchPerfect;
            }
            return JudgmentResultType.MatchForward;
        }
    }
}
