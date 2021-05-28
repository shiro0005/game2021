using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTransition: MonoBehaviour
{

    //この関数を呼び出すとBuildsettingのシーンの番号で移動するシーンを選択
    public static void Nextscene(int n)
    {
        FadeManager.FadeOut(n);
    }
}
