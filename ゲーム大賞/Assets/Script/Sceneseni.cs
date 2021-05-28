using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sceneseni: MonoBehaviour
{

    public int m_scene;
    private static bool Flag = false;

    private void Start()
    {
        Flag = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"&&!Flag)
        {
            SceneTransition.Nextscene(m_scene);
            Flag = true;
        }
    }
    
   
}
