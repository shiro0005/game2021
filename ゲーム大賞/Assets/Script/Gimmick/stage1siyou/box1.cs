using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box1 : MonoBehaviour
{
    public GameObject who;
    public GameObject mat;
    Rigidbody2D rb2d;

    public GameObject FisText;
    bool Textflag;

    // Start is called before the first frame update
    void Start()
    {
        Textflag = true;
        FisText.SetActive(Textflag);
        //rb = GetComponent<Rigidbody>();
        Rigidbody2D rd2d = GetComponent<Rigidbody2D>();

        //rb2d.constraints = RigidbodyConstraints2D.FreezePositionX
        //    | RigidbodyConstraints2D.FreezePositionX
        //    | RigidbodyConstraints.FreezeRotationX
        //    | RigidbodyConstraints.FreezeRotationZ;
        rd2d.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
    //void GimmickStart()
    //{
    //    gameObject.AddComponent<Rigidbody>();
    //}

    //void GimmickEnd()
    //{
    //    Destroy(mat.GetComponent<Rigidbody>());
    //}

    //ééóp
    void OnCollisionStay2D(Collision2D col)
    {
        if (who.gameObject.activeInHierarchy)
        {
            Debug.Log("colÇ™êGÇÍÇƒÇ¢ÇÈ");
            if (Input.GetKey(KeyCode.Space))
            {
                //3DópÇÃrigidbodyîõÇË
                //rb.constraints = RigidbodyConstraints.None;
                //rb.constraints = RigidbodyConstraints.FreezePositionZ
                //| RigidbodyConstraints.FreezeRotationX
                //| RigidbodyConstraints.FreezeRotationZ;

                this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

                Textflag = true;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        //3DópÇÃrigidbodyîõÇË
        //rb.constraints = RigidbodyConstraints.FreezePositionZ
        //| RigidbodyConstraints.FreezePositionX
        //| RigidbodyConstraints.FreezeRotationX
        //| RigidbodyConstraints.FreezeRotationZ;

        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition 
            | RigidbodyConstraints2D.FreezeRotation;

        Textflag = false;

    }
}
