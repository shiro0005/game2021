using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box1 : MonoBehaviour
{
    public GameObject who;
    public GameObject mat;
    Rigidbody2D rb2d;

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
            if (Input.GetKey(KeyCode.K))
            {

                this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

                //Textflag = false;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {

        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX 
            | RigidbodyConstraints2D.FreezeRotation;

        //Textflag = true;

    }
}
