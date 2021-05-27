using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GametoTitle : MonoBehaviour
{
    public GameObject gameclear;
    private bool flag = false;
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject.GetComponent<Move>());
        gameclear.GetComponent<Text>();
        gameclear.SetActive(true);
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
