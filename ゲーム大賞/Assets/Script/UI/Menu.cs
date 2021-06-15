using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private GameObject child;                           //Canvasの子供（UIManagerをいれる）
    private GameObject[] ButtonUI = new GameObject[4];    //メニューのボタンを取得　ボタンの数を[]の中にいれる
    private bool PauseCheck;                            //一時停止しているかのの判定
    private int num;　                                  //ボタン操作用の数
    public AudioSource audioSource;                     //SE削除用
    [SerializeField] int ThisScene;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        PauseCheck = false;
        child = transform.Find("UIManager").gameObject;             //UIManager取得
        for (int i = 0; i < ButtonUI.Length; i++)
        {
            ButtonUI[i] = child.transform.GetChild(i + 2).gameObject; //ボタン取得
        }
        child.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();//一時停止
        }



        if (PauseCheck)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ButtonUI[num].transform.localScale /= 1.1f;
                num--;
                if (num < 0)
                {
                    num = ButtonUI.Length - 1;
                }
                ButtonUI[num].transform.localScale *= 1.1f;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                ButtonUI[num].transform.localScale /= 1.1f;
                num++;
                if (num > ButtonUI.Length - 1)
                {
                    num = 0;
                }
                ButtonUI[num].transform.localScale *= 1.1f;
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                switch (num)
                {
                    case 0:
                        UnPause();//再生
                        break;
                    case 1:
                        UnPause();
                        SceneTransition.Nextscene(0);
                        break;
                    case 2:
                        UnPause();
                        SceneTransition.Nextscene(ThisScene);   //インスペクターでシーンを設定　リスタート用
                        break;
                    case 3:
                        #if UNITY_EDITOR
                            UnityEditor.EditorApplication.isPlaying = false;
                        #else
                            Application.Quit();
                        #endif
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        audioSource.enabled = false;
        child.SetActive(true);
        PauseCheck = true;
        ButtonUI[0].transform.localScale *= 1.1f;
    }
    private void UnPause()
    {
        Time.timeScale = 1;
        child.SetActive(false);
        audioSource.enabled = true;
        PauseCheck = false;
    }
}
