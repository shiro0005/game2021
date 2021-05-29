using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // 追加しましょう

public class Death_CC : MonoBehaviour
{
    //public GameObject score_object = null; // Textオブジェクト

    public int sateg_deth;

    //public GameObject p_Number;



    public GameObject player;
    public int m_scene;

    int death_Count = 0;
    int old_Death_Count = 0;
    bool flag = false;
    public AudioClip transitionSE;

    // 初期化
    void Start()
    {
        //p_Number = number.GetComponent<number>();
    }

    // 更新
    void Update()
    {
        death_Count = player.GetComponent<Player>().GetDeathCount();

        if (sateg_deth - death_Count < 0&&!flag)
        {
            //GemaOver
            SE.instance.PlaySE(transitionSE);
            SceneTransition.Nextscene(m_scene);
            flag = true;
        }

        //// オブジェクトからTextコンポーネントを取得
        //Text score_text = score_object.GetComponent<Text>();
        //// テキストの表示を入れ替える
        //score_text.text = " ×　" + (sateg_deth - death_Count);


        //if(old_Death_Count != death_Count)
        //{
        //    p_Number.GetComponent<number>().ChengNum(3);
        //}

        old_Death_Count = death_Count;
    }

    public int GetZanki()
    {
        return sateg_deth - death_Count;
    }
}