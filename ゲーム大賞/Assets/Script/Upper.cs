using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upper : MonoBehaviour
{

    public GameObject Hito;
    Rigidbody rb;
    private Vector3 normalpos;

    //public GameObject upper;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        normalpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(new Vector3(normalpos.x + Mathf.PingPong(Time.time, 2), normalpos.y, normalpos.z));
    }

    void OnCollisionEnter(Collision col)
    {
        //確認用
        Debug.Log(col.gameObject.name);//衝突したobjの名前を取得

        if (col.gameObject.name == "Human")
        {
            Debug.Log("せいこう");
            //Hito.gameObject.transform.SetParent(this.transform);
            //transform.parent = GameObject.Find("Human").transform;
            //Debug.Log("親子");
            //Destroy(Hito.GetComponent<Rigidbody>());
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("押せてる");
        //    rb.MovePosition(new Vector3(normalpos.x + Mathf.PingPong(Time.time, 2), normalpos.y, normalpos.z));
        //}
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Human")
        {
            Debug.Log("離れてる");
            //transform.SetParent(null);
            //gameObject.AddComponent<Rigidbody>();

        }
    }
}
