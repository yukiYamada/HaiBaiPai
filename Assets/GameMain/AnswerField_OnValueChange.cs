using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Questions;
using Assets.BaseObject;
using Assets.GameMain;

public class AnswerField_OnValueChange : MonoBehaviour {

    // staticで大丈夫かな。不安
    private static InputField _field;
    private InputField Field
    {
        get
        {
            // 何度もコンポーネントからとらんでもいけるやろ。きっと
            if (_field == null)
            {
                _field = GetComponent<InputField>();
            }
            return _field;
        }
    }

	// Update is called once per frame
	public void OnValueChange () {
        var gmc = new GameControl();

        gmc.JudgeAnswer(Field);
	}
}
