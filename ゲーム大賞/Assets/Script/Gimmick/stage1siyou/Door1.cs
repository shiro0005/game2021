using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    Rigidbody rb;
    bool Oneflag;

    float speed = 1.0f;
    //public float BeginY;
    //public float MoverY;

    public Vector2 direction = new Vector2(0.0f, 5.0f);
    public Vector2 down = new Vector2(0.0f, 2.5f);



    // Start is called before the first frame update
    void Start()
    {
        //取り合えずコメントアウト
        //Oneflag = false;

        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Oneflag == true)
        //{
        //    DoirOpen1();
        //}

        //if (Oneflag == false)
        //{
        //    DoirClose1();
        //}
    }

    public void DoirOpen1()
    {
        //Oneflag = true;

        //float step = speed * Time.deltaTime;
        //transform.position = Vector2.MoveTowards(transform.position, direction, step);
        //transform.position = Vector2.MoveTowards(transform.position, direction, step);

        //transform.position += new Vector3(0f, 0.1f, 0f);
        //transform.position += new Vector3(0f, 5.0f, 0f);

        transform.Translate(new Vector2(0, 5.0f));

        //transform.position = new Vector3(0f, MoverY, 0f);
    }

    public void DoirClose1()
    {
        //Oneflag = false;

        //float step = speed * Time.deltaTime;
        //transform.position = Vector2.MoveTowards(transform.position, down, step);
        //transform.position = down;
        //transform.position = new Vector3(0f, BeginY, 0f);

        transform.Translate(new Vector2(0, 2.5f));

        //transform.position += new Vector3(0f, 2.5f, 0f);
    }
}
