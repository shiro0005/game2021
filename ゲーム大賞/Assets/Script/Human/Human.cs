//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Human : MonoBehaviour
//{
//    private float speed;
//    public Rigidbody rb;
//    bool isFloor;

//    [SerializeField] private GameObject Player;

//    private Move PlayerAction;
//    //Rigidbody Brb;

//    // Start is called before the first frame update
//    void Start()
//    {
//        rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得   

//        PlayerAction = Player.GetComponent<Move>();
//        //Brb = PlayerAction.rb;

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    void HumanMove()
//    {
//        if (isFloor)
//        {
//            float x = Input.GetAxis("Horizontal");
//            if (x > 0.2 || x < -0.2)
//            {
//                speed = 10;
//                rb.velocity = new Vector3(x * speed, rb.velocity.y, rb.velocity.z);
//                //Debug.Log("移動");
//            }
//            else
//            {
//                speed = 0;
//            }
//        }
//    }

//    void HumanAction(Collision collision)
//    {
//        if (Input.GetKeyDown("space"))
//        {
//            //collision.GimmickStart();   //GimmickStartを呼ぶ
//        }
//    }


//    void HumanJump()
//    {
//        if (Input.GetKeyDown("space"))
//        {
//            Vector3 force = new Vector3(0.0f, 8.0f, 0.0f);  // 力を設定
//            PlayerAction.rb.AddForce(force, ForceMode.Impulse);// 力を加える
//            Debug.Log("跳んだ!");
//        }
//    }


//    void OnCollisionStay(Collision collision)
//    {
//        if (collision.gameObject.tag == "Floor")
//        {
//            isFloor = true;
//        }
//    }

//    void OnCollisionExit(Collision collision)
//    {  //"Floor"タグが付いているオブジェクト
//        if (collision.gameObject.tag == "Floor")
//        {
//            isFloor = false;
//        }
//    }

//    void GimmickStart()
//    {

//    }

//}

