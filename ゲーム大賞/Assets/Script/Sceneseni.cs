using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sceneseni : MonoBehaviour
{
    public int m_scene;
    private static bool Flag = false;
    public AudioClip transitionSE;

    private void Start()
    {
        Flag = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneTransition.Nextscene(m_scene);
            Flag = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.name == "goal")
        {
            if (collision.gameObject.name == "soccer_ball")
            {
                SE.instance.PlaySE(transitionSE);
                SceneTransition.Nextscene(m_scene);
                Flag = true;
            }
        }
        else if (this.gameObject.name == "Hell")
        {
            if (collision.gameObject.tag == "Player")
            {
                SE.instance.PlaySE(transitionSE);
                SceneTransition.Nextscene(m_scene);
                Flag = true;
            }
        }
    }
}