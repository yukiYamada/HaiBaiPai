using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.BaseObject
{
    public enum JudgmentResultType
    {
        // 一部一致
        MatchForward = 0,
        // 完全一致
        MatchPerfect,
        // 不一致
        NG
    }
}
