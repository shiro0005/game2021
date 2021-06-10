using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human2D : MonoBehaviour
{
    private float speed;
    public float Speed;
    public float jamp;
    Rigidbody2D rb2D;
    public bool isFloor = true;
    public AudioClip jumpSE;

    private float weight = 0.3f;

    [SerializeField] private GameObject Player;

    private Animator anim = null;

    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = Player.GetComponent<Rigidbody2D>();  // rigidbody���擾   

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.K))
        {
            anim.SetBool("osu", true);
            HumanMove(weight);
            HumanJump();
        }
        else
        {
            anim.SetBool("osu", false);
            HumanMove(1.0f);
            HumanJump();
        }


        if (!isFloor)
        {
            Debug.Log("����Ă�");
        }
    }

    void HumanMove(float weight)
    {
        if (isFloor)
        {
            Vector3 scale = transform.localScale;

            float x = Input.GetAxis("Horizontal");
            if (x > 0.2 )
            {
                speed = Speed;
                rb2D.velocity = new Vector2(x * speed*weight, rb2D.velocity.y);//, rb.velocity.z);
                //Debug.Log("�ړ�");

                anim.SetBool("run", true);

                scale.x = 50;
            }
            else if( x < -0.2)
            {
                speed = Speed;
                rb2D.velocity = new Vector2(x * speed*weight, rb2D.velocity.y);//, rb.velocity.z);
                //Debug.Log("�ړ�");

                anim.SetBool("run", true);

                scale.x = -50;
            }

            else
            {
                speed = 0;
                anim.SetBool("run", false);
            }

            transform.localScale = scale;
        }
    }

    void HumanAction(Collision2D collision)
    {
        if (Input.GetKeyDown("space"))
        {
            //collision.GimmickStart();   //GimmickStart���Ă�
        }
    }


    void HumanJump()
    {
        if (isFloor)
        {
            if (Input.GetKeyDown("space"))
            {
                Vector3 force = new Vector3(0.0f, 8.0f, 0.0f);  // �͂�ݒ�
                rb2D.velocity = new Vector2(rb2D.velocity.x, jamp);//, rb.velocity.z);
                Debug.Log("����!");
                SE.instance.PlaySE(jumpSE);
                anim.SetBool("isJamp", true);
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;

            anim.SetBool("isJamp", false);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = true;
        }
    }
    

    private void OnCollisionExit2D(Collision2D collision)
    {  //"Floor"�^�O���t���Ă���I�u�W�F�N�g
        if (collision.gameObject.tag == "Floor")
        {
            isFloor = false;
            Debug.Log("����");
        }
    }

    void GimmickStart()
    {

    }

}
