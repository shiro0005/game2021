using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upper : MonoBehaviour
{

    public GameObject Hito;
    Rigidbody rb;
    private Vector3 normalpos;
    private bool onber = false;
    private bool gimmickswitch = false;
    //public GameObject upper;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        normalpos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (onber&&Input.GetKeyDown(KeyCode.Space))
        {
            gimmickswitch = true;
        }

        if (gimmickswitch)
        {
            rb.MovePosition(transform.position + transform.right*4.5f * Time.deltaTime);
            //rb.MovePosition(new Vector3(normalpos.x + Mathf.PingPong(Time.time, 5), normalpos.y, normalpos.z));
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("notta");
      
        if (col.gameObject.name == "Target")
        {
            if (Hito.gameObject.activeInHierarchy)
            {
                onber = true;
                Debug.Log("hito");
            }
            else
            {
                onber = false;
                gimmickswitch = false;
            }
            //Hito.gameObject.transform.SetParent(this.transform);
            //transform.parent = GameObject.Find("Human").transform;
            //Debug.Log("êeéq");
            //Destroy(Hito.GetComponent<Rigidbody>());
        }

    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Target")
        {
            Debug.Log("hanareta");
            onber = false;
            gimmickswitch = false;
            //transform.SetParent(null);
            //gameObject.AddComponent<Rigidbody>();
        }
        
    }
}
