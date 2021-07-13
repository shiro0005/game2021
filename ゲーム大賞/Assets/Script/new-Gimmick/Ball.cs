using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject KeyObject;
    //[SerializeField] GameObject Player;
    [SerializeField] Vector2 vec;
    [SerializeField] bool beginning;

    private void Start()
    {
        if (beginning)//最初からボールを動かす
        {
            this.GetComponent<Rigidbody2D>().velocity = vec;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //回転
        this.GetComponent<Rigidbody2D>().angularVelocity = -this.GetComponent<Rigidbody2D>().velocity.x * 30f; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")//ゲームオーバー
        {
            SceneTransition.Nextscene(0);
        }
        else if (collision.gameObject == KeyObject)//任意のタイミングで動かす
        {
            this.GetComponent<Rigidbody2D>().velocity = vec;
        }
        if (collision.gameObject.layer == 10)//カベの跳ね返り用
        {
            this.GetComponent<Rigidbody2D>().velocity= collision.gameObject.GetComponent<reflection>().GetVector();
        }
        
    }
}
