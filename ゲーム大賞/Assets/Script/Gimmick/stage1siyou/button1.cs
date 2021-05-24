using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    GameObject havescript;
    //public GameObject who;//人
    public GameObject box;//錘
    public bool open;

    // Start is called before the first frame update
    void Start()
    {
        havescript = GameObject.Find("door");
        open = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D col)
    {
        //人の場合
        //if (col.gameObject.name == "Human")
        //{
        //    if (who.gameObject.activeInHierarchy)
        //    {
        //        Debug.Log("人が乗ってる");
        //        open = true;
        //        //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
        //        havescript.GetComponent<Mover>().DoirOpen();
        //    }
        //}

        //箱の場合
        if (col.gameObject.name == "box")
        {
            if (box.gameObject.activeInHierarchy)
            {
                Debug.Log("箱が乗ってる");
                open = true;
                //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                havescript.GetComponent<Door1>().DoirOpen();
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        //人の場合
        //if (who.gameObject.activeInHierarchy)
        //{
        //    Debug.Log("人が離れた");
        //    open = false;
        //    //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
        //    havescript.GetComponent<Mover>().DoirClose();
        //}

        //箱の場合
        if (box.gameObject.activeInHierarchy)
        {
            Debug.Log("箱が離れた");
            open = false;
            //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
            havescript.GetComponent<Door1>().DoirClose();
        }
    }
}
