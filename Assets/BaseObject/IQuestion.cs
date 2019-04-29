using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.BaseObject
{
    // 問題一覧
    public interface IQuestion
    {
        /// <summary>
        /// 画像
        /// </summary>
        CustomSprite Sprite {get;}

        /// <summary>
        /// 回答
        /// </summary>
        Answer Answer {get;}

        /// <summary>
        /// ヒント
        /// </summary>
        Hint Hint {get;}

        /// <summary>
        /// 回答の全文
        /// </summary>
        AnswerFullName AnswerFullName { get; }
    }
}
