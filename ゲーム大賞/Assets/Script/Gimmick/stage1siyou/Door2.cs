using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    //Rigidbody rb;
    //bool Twoflag;

    //float speed = 1.0f;
    //public float BeginY;
    //public float MoverY;

    public Vector2 direction = new Vector2(0.0f, 12.0f);
    public Vector2 down = new Vector2(0.0f, 6.0f);



    // Start is called before the first frame update
    void Start()
    {
        //Twoflag = false;
        //rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Twoflag == true)
        //{
        //    DoirOpen2();
        //}

        //if (Twoflag == false)
        //{
        //    DoirClose2();
        //}
    }

    public void DoirOpen2()
    {
        //Twoflag = true;
        //float step = speed * Time.deltaTime;
        //transform.position = Vector2.MoveTowards(transform.position, direction, step);

        //transform.position = new Vector3(0f, MoverY, 0f);

        transform.Translate(new Vector2(0, 12.0f));
    }

    public void DoirClose2()
    {
        //Twoflag = false;
        //float step = speed * Time.deltaTime;
        //transform.position = Vector2.MoveTowards(transform.position, down, step);


        transform.Translate(new Vector2(0, 6.0f));
        //transform.position = new Vector3(0f, BeginY, 0f);
    }
}
