using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.BaseObject
{
    public class QuestionResources
    {
        private readonly List<QuestionResource> _resources;
        public QuestionResources(string directory)
        {
            _resources = new List<QuestionResource>();
            foreach (var parent in System.IO.Directory.GetDirectories(directory))
            {
                //haiかbaiかpaiか
                foreach (var question in System.IO.Directory.GetDirectories(parent + "/"))
                {
                    _resources.Add(new QuestionResource(new QuestionResourcePath(question)));
                }
            }
        }

        private static int _selectedIdx;
        public IQuestion Selected { get { return _resources[_selectedIdx]; } }

        public IQuestion SelectOne()
        {
            _selectedIdx = GetRandumIdx();
            return Selected;
        }

        private int GetRandumIdx()
        {
            //シード値(1000)を使用して初期化
            //シード値が変わらなければ毎回同じ乱数を返す
            System.Random r = new System.Random();

            //-10以上10未満の乱数を整数で返す
            return r.Next(0, _resources.Count());
        }
    }
}
