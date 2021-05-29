using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public GameObject box;//錘
    public bool open;
    public GameObject child;
    public AudioClip BGM_Gim;

    // Start is called before the first frame update
    void Start()
    {
        open = false;
        Debug.Log("Child:" + child.name);//子のログ
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D col)
    {
        //箱の場合
        if (col.gameObject.name == "box")
        {
            if (box.gameObject.activeInHierarchy)
            {
                Debug.Log("箱が乗ってる");
                open = true;
                //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                child.GetComponent<Door1>().DoirOpen1();
                SE.instance.PlaySE(BGM_Gim);
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        //箱の場合
        if (box.gameObject.activeInHierarchy)
        {
            Debug.Log("箱が離れた");
            open = false;
            //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
            child.GetComponent<Door1>().DoirClose1();
        }
    }
}
