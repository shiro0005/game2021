using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // 追加しましょう


public class Score : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト

    public int x;
    // 初期化
    void Start()
    {
        x = 10;
    }

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "死んだ回数　"+ x; 
    }
}