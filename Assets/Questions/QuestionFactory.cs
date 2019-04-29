using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.BaseObject;

namespace Assets.Questions
{
    public static class QuestionFactory
    {
        public static IQuestion Create(QuestionResourcePath resourcePath)
        {
            QuestionResource resource = new QuestionResource(resourcePath);

            IQuestion returnObject = null;
            switch (resource.Answer.Value)
            {
                case "hai":
                    returnObject =  new Hai(resource);
                    break;
                case "bai":
                    returnObject = new Bai(resource);
                    break;
                case "pai":
                    returnObject = new Pai(resource);
                    break;
            }
            return returnObject;
        }
    }
}
