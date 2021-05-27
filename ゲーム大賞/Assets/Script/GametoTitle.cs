using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GametoTitle : MonoBehaviour
{
    public GameObject gameclear;
    private bool flag = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(collision.gameObject.GetComponent<Move>());
        gameclear.GetComponent<Text>();
        gameclear.SetActive(true);
        FadeManager.FadeOut(0);
        flag = true;
       
    }
    void Update()
    {
        if (flag)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                
                Debug.Log("ÉSÅ[ÉãÅI");
               SceneManager.LoadScene("Title");
                
            }
        }
    }
}
