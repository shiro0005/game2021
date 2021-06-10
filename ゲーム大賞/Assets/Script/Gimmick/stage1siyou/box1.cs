using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box1 : MonoBehaviour
{
    public GameObject who;
    public GameObject mat;
    Rigidbody2D rb2d;
    public GameObject boxUI;

    //public GameObject FisText;
    //bool Textflag;

    // Start is called before the first frame update
    void Start()
    {
        //Textflag = true;
        //FisText.SetActive(Textflag);
        Rigidbody2D rd2d = GetComponent<Rigidbody2D>();

        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX
            | RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //èëÇ©Ç»Ç¢
    }
 
    //ééóp
    void OnCollisionStay2D(Collision2D col)
    {
        if (who.gameObject.activeInHierarchy)
        {
            Debug.Log("êlÇ™êGÇÍÇƒÇ¢ÇÈ");
            if (col.gameObject.name == "Player")
            {
                boxUI.GetComponent<gimibox_UI>().afterGimmickUI();
                if (Input.GetKey(KeyCode.K))
                {
                    //boxUI.GetComponent<gimibox_UI>().afterGimmickUI();
                    this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {

        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX 
            | RigidbodyConstraints2D.FreezeRotation;
        boxUI.GetComponent<gimibox_UI>().beforeGimmickUI();

    }
}
