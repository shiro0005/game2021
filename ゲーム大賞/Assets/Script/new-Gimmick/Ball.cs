using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject KeyObject;
    [SerializeField] GameObject Player;
    private bool Flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyObject.GetComponent<Signal>().Touch)
        {
            Flag = true;
        }

        if (Flag)
        {
            float x = Player.transform.position.x - this.transform.position.x;
            x = Mathf.Sign(x) * 5.0f;
            this.GetComponent<Rigidbody2D>().velocity= new Vector2(x, this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneTransition.Nextscene(0);
        }
    }
}
