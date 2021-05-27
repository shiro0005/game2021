using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitletoGame : MonoBehaviour
{

    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        //SceneManager.LoadScene("stage1");
        FadeManager.FadeOut(1);
        Debug.Log("押された!");  // ログを出力
    }
}
