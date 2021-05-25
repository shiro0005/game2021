using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // 追加しましょう

public class Death_CC : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト

    public int sateg_deth;

    int death_Count = 0;
    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        death_Count = Player.instance.GetDeathCount();

        if (sateg_deth - death_Count <= 0)
        {
            //GemaOver

        }

        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = " ×　" + (sateg_deth - death_Count);
    }
}