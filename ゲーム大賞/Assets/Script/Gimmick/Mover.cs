using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody rb;
    bool flag;

    float speed = 1.0f;

    Vector3 direction = new Vector3(0, 5f,0f);
    Vector3 down = new Vector3(0f, 2.5f, 0);



    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag==true)
        {
            DoirOpen();
        }

        if(flag==false)
        {
            DoirClose();
        }
    }

    public void DoirOpen()
    {
        flag = true;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, direction, step);
    }

    public void DoirClose()
    {
        flag = false;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, down, step);
    }

}
