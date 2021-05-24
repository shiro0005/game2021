using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    Rigidbody rb;
    bool flag;

    float speed = 1.0f;
    //public float BeginY;
    //public float MoverY;

    public Vector2 direction = new Vector3(0.0f, 5.0f);
    public Vector2 down = new Vector3(0.0f, 2.5f);



    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (flag == true)
        //{
        //    DoirOpen();
        //}

        //if (flag == false)
        //{
        //    DoirClose();
        //}
    }

    public void DoirOpen()
    {
        flag = true;
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, direction, step);

        //transform.position = new Vector3(0f, MoverY, 0f);
    }

    public void DoirClose()
    {
        flag = false;
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, down, step);

        //transform.position = new Vector3(0f, BeginY, 0f);
    }
}
