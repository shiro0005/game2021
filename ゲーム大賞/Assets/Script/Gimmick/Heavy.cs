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
        Textflag = true;
        FisText.SetActive(Textflag);
        rb = GetComponent<Rigidbody>();

        rb.constraints = RigidbodyConstraints.FreezePositionZ
            | RigidbodyConstraints.FreezePositionX
            | RigidbodyConstraints.FreezeRotationX
            | RigidbodyConstraints.FreezeRotationZ;
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
            Debug.Log("êlÇ™êGÇÍÇƒÇ¢ÇÈ");
            if (Input.GetKey(KeyCode.Space))
            {
                //rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezePositionZ
                | RigidbodyConstraints.FreezeRotationX
                | RigidbodyConstraints.FreezeRotationZ;

                Textflag = true;
            }
        }
    }

    private void OnCollisionExit(Collision col)
    {
<<<<<<< HEAD
        
=======
>>>>>>> 79164b90ba8b7a43a53d48c0b5b61e5e12706c34
            rb.constraints = RigidbodyConstraints.FreezePositionZ
            | RigidbodyConstraints.FreezePositionX
            | RigidbodyConstraints.FreezeRotationX
            | RigidbodyConstraints.FreezeRotationZ;

            Textflag = false;
<<<<<<< HEAD
       
=======
        
>>>>>>> 79164b90ba8b7a43a53d48c0b5b61e5e12706c34
    }
}
