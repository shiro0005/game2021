using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GtoT : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        //SceneManager.LoadScene("Title");
        FadeManager.FadeOut(0);
        Debug.Log("��������!");
    }
}
