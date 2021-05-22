using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastAction : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Move PlayerAction;

    public AudioClip jumpSE;

    
    private float speed;
    private float gravity;

    Rigidbody Brb;

    //GameObject Player; //Playerちゃんそのものが入る変数

    //Move script; //Moveが入る変数

    //Start is called before the first frame update
    void Start()
    {
        PlayerAction = Player.GetComponent<Move>();

        Brb = PlayerAction.rb;


    }

    void Update()
    {
        //プレイヤーが地面と接触してる時=========================================================================
        if (PlayerAction.isFloor)
        {
            //接触した状態でspaceキーが押されたときジャンプ--------------------------------
            if (Input.GetKeyDown("space"))
            {
                Vector3 force = new Vector3(0.0f, 6.0f, 0.0f);  // 力を設定
                PlayerAction.rb.AddForce(force, ForceMode.Impulse);          // 力を加える
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
            PlayerAction.rb.velocity = new Vector3(speed, PlayerAction.rb.velocity.y, PlayerAction.rb.velocity.z);
            //-----------------------------------------------------------------------------
        }
        //==========================================================================================================

     

        //プレイヤーが空中にいるとき================================================================================
        if(PlayerAction.isFloor==false)
        {
            
            //----------------------------------------------------------------------------------

            //Eキーを押してる間だけ滑空---------------------------------------------------------
            if (Input.GetKey(KeyCode.E))
            {
                gravity = -1.0f;  //値を下げれば重くなる
                PlayerAction.rb.velocity = new Vector3(PlayerAction.rb.velocity.x, PlayerAction.rb.velocity.y*gravity, PlayerAction.rb.velocity.z);

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
                 PlayerAction.rb.velocity = new Vector3(speed, PlayerAction.rb.velocity.y, PlayerAction.rb.velocity.z);
            }
            //----------------------------------------------------------------------------------
        }
        //============================================================================================================
    }
}