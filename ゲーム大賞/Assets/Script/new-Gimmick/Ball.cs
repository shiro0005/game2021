using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject KeyObject;
    //[SerializeField] GameObject Player;
    [SerializeField] Vector2 vec;
    [SerializeField] bool beginning;
    [SerializeField] int scene_num;
    private void Start()
    {
        if (beginning)//最初からボールを動かす
        {
            this.GetComponent<Rigidbody2D>().velocity=vec;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //回転
        this.GetComponent<Rigidbody2D>().angularVelocity = -this.GetComponent<Rigidbody2D>().velocity.x * 30f;

        if (this.GetComponent<Rigidbody2D>().velocity.x != 0.0f)
        {
                //this.GetComponent<Rigidbody2D>().velocity=new Vector2(vec.x, this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")//ゲームオーバー
        {
            SceneTransition.Nextscene(scene_num);
        }
        else if (collision.gameObject == KeyObject)//任意のタイミングで動かす
        {
            this.GetComponent<Rigidbody2D>().velocity = vec;
        }
        
        if (collision.gameObject.layer == 10)//カベの跳ね返り用
        {
            this.GetComponent<Rigidbody2D>().velocity= collision.gameObject.GetComponent<reflection>().GetVector(this.GetComponent<Rigidbody2D>().velocity);
        }
        
    }
}
