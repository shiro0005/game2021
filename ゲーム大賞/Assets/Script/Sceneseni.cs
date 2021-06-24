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
        if (collision.gameObject.tag == "Player" && !Flag)
        {
            SE.instance.PlaySE(transitionSE);
            SceneTransition.Nextscene(m_scene);
            Flag = true;
        }
    }
}