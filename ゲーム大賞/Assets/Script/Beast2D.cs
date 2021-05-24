using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beast2D : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    

    public AudioClip jumpSE;
    private float speed;
    private float gravity;
    private bool isFloor;

    //GameObject Player; //Playerちゃんそのものが入る変数

    //Move script; //Moveが入る変数

    //Start is called before the first frame update
    void Start()
    {

        //PlayerAction = Player.GetComponent<Move>();

        //Brb = PlayerAction.rb;
        rb = this.GetComponent<Rigidbody2D>();

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {  //"Floor"タグが付いているオブジェクト
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = false;
        }
    }


    void Update()
    {
        //プレイヤーが地面と接触してる時=========================================================================
        if (isFloor)
        {
            //接触した状態でspaceキーが押されたときジャンプ--------------------------------
            if (Input.GetKeyDown("space"))
            {
                Vector2 force = new Vector3(0.0f, 6.0f);     // 力を設定
                rb.AddForce(force, (ForceMode2D)ForceMode.Impulse);// 力を加える
                SE.instance.PlaySE(jumpSE);
                //Debug.Log("跳んだ!");
            }

            //-----------------------------------------------------------------------------

            //プレイヤーの移動速度変更-----------------------------------------------------
            //float x = Input.GetAxis("Horizontal");
            //if (x > 0.2 || x < -0.2)
            //{
            //    speed = 20;
            //    //PlayerAction.rb.velocity = new Vector3(x * speed, PlayerAction.rb.velocity.y, PlayerAction.rb.velocity.z);
            //}
            //else
            //{
            //    speed = 0;
            //}

            if (Input.GetKey(KeyCode.D))
            {
                speed = 8;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                speed = -8;
            }
            else
            {
                speed = 0.0f;
            }
            rb.velocity = new Vector2(speed, rb.velocity.y);
            //-----------------------------------------------------------------------------
        }
        //==========================================================================================================



        //プレイヤーが空中にいるとき================================================================================
        if (!isFloor)
        {

            //----------------------------------------------------------------------------------

            //Eキーを押してる間だけ滑空---------------------------------------------------------
            if (Input.GetKey(KeyCode.E))
            {
                // gravity = -1.0f;  //値を下げれば重くなる
                rb.velocity = new Vector2(rb.velocity.x, -0.3f);

                //空中でのプレイヤー移動-----------------------------------------------------------
                if (Input.GetKey(KeyCode.D))
                {
                    speed = 8;
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    speed = -8;
                }
                else
                {
                    speed = 0.0f;
                }

                rb.velocity = new Vector3(speed, rb.velocity.y);
            }
            //----------------------------------------------------------------------------------
        }
        //============================================================================================================
    }
}