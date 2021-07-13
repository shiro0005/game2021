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
        if (beginning)//�ŏ�����{�[���𓮂���
        {
            this.GetComponent<Rigidbody2D>().velocity = vec;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //��]
        this.GetComponent<Rigidbody2D>().angularVelocity = -this.GetComponent<Rigidbody2D>().velocity.x * 30f; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")//�Q�[���I�[�o�[
        {
            SceneTransition.Nextscene(0);
        }
        else if (collision.gameObject == KeyObject)//�C�ӂ̃^�C�~���O�œ�����
        {
            this.GetComponent<Rigidbody2D>().velocity = vec;
        }
        if (collision.gameObject.layer == 10)//�J�x�̒��˕Ԃ�p
        {
            this.GetComponent<Rigidbody2D>().velocity= collision.gameObject.GetComponent<reflection>().GetVector();
        }
        
    }
}
