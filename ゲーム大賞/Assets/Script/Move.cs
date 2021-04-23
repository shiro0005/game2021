using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private float speed;
    public Rigidbody rb;
    public  bool isFloor;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得  

    }

    void OnCollisionStay(Collision collision)
    {  //"Floor"タグが付いているオブジェクト

        isFloor = true;
      
    }

    void OnCollisionExit(Collision collision)
    {  //"Floor"タグが付いているオブジェクト

        isFloor = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFloor)
        {
            float x = Input.GetAxis("Horizontal");
            if (x > 0.2 || x < -0.2)
            {
                speed = 10;
                rb.velocity = new Vector3(x * speed, rb.velocity.y, rb.velocity.z);
                //Debug.Log("移動");
            }
            else
            {
                speed = 0;
            }

        }
    }

}