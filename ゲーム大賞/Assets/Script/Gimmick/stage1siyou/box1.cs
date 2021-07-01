using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box1 : MonoBehaviour
{
    public GameObject who;//人を追加
    //public GameObject mat;//どのボックス(岩)を指定するか
    Rigidbody2D rb2d;
    public GameObject boxUI;//BoxUIを追加
    public float XPosSeconds;//試験運用:XPosのフリーズを遅らせる。

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rd2d = GetComponent<Rigidbody2D>();

        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX
            | RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //書かない
        //this.OnCollisionStay2D();
    }

    public void OnCollisionStay2D(Collision2D col)
    {
        if (who.gameObject.activeInHierarchy)
        {
            if (col.gameObject.name == "Player")
            {
                boxUI.GetComponent<gimibox_UI>().afterGimmickUI();
                if (Input.GetKey(KeyCode.K))
                {
                    this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            }
        }
        //人以外が触れた時、箱自体のPos,Rotを止めますわ
        else
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition
            | RigidbodyConstraints2D.FreezeRotation;

            boxUI.GetComponent<gimibox_UI>().beforeGimmickUI();
        }
    }

    public void OnCollisionExit2D(Collision2D col)
    {
        //途中御触り禁止でございますわ
        if (who.gameObject.activeInHierarchy)
        {
            //Debug.Log("箱からお離れになられたのですわ!");
            XPosSeconds += Time.deltaTime;

            if (XPosSeconds <= 0.9)
            {
                this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                XPosSeconds++;
            }
            else if (XPosSeconds >= 1.0)
            {
                this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX
                | RigidbodyConstraints2D.FreezeRotation;
                XPosSeconds = 0;
            }
        }

    }
}
