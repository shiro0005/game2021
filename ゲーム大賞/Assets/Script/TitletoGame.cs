using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitletoGame : MonoBehaviour
{
    public int m_scene;
    private static bool Flag = false;

    public AudioClip GemaToGoSE;

    private void Start()
    {
        Flag = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&!Flag)
        {
            SceneTransition.Nextscene(m_scene);
            SE.instance.PlaySE(GemaToGoSE);
            Flag = true;
        }
    }
}
