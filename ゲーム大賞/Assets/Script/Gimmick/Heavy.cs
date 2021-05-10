using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heavy : MonoBehaviour
{
    public GameObject who;
    public GameObject mat;
    Rigidbody rb;

    public GameObject FisText;
    bool Textflag;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        Textflag = true;
        this.FisText.SetActive(Textflag);
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
    void OnCollisionStay(Collision col)
    {
        if (who.gameObject.activeInHierarchy)
        {
            Debug.Log("colÇ™êGÇÍÇƒÇ¢ÇÈ");
            if (Input.GetKey(KeyCode.Space))
            {
                mat.AddComponent<Rigidbody>();
                rb.constraints = RigidbodyConstraints.FreezeRotation;
                Textflag = false;
            }
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (who.gameObject.activeInHierarchy)
        {
            Destroy(mat.GetComponent<Rigidbody>());
            Textflag = false;
        }
    }
}
