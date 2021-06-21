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



        if (PauseCheck)//一時停止中なら
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ButtonUI[num].transform.localScale /= 1.1f;//元のサイズ
                num--;
                if (num < 0)
                {
                    num = ButtonUI.Length - 1;
                }
                ButtonUI[num].transform.localScale *= 1.1f;//拡大表現
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
                        SceneTransition.Nextscene(0);//タイトル
                        break;
                    case 2:
                        UnPause();
                        SceneTransition.Nextscene(ThisScene);   //インスペクターでシーンを設定　リスタート用
                        break;
                    case 3:
                        #if UNITY_EDITOR
                            UnityEditor.EditorApplication.isPlaying = false;//ゲームを終了する
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
        Time.timeScale = 0;                         //時間を止める
        audioSource.enabled = false;                //SEを止める
        child.SetActive(true);                      //Menu画面をだす
        PauseCheck = true;                          //一時停止中のフラグ
        ButtonUI[0].transform.localScale *= 1.1f;   //拡大表現
    }

    private void UnPause()
    {
        Time.timeScale = 1;
        child.SetActive(false);
        audioSource.enabled = true;
        PauseCheck = false;
    }

    public bool GetMenu()//これを取得して各スクリプトでこれを条件式にいれる
    {
        return PauseCheck;
    }
}
