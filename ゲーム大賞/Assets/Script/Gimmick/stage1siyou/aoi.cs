using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aoi : MonoBehaviour
{
    public Texture texture;
    public Texture texture2;
    GameObject HanB;
    Hantei_B WallBox_B;

    bool switchBox;
    // Start is called before the first frame update
    void Start()
    {
        HanB = GameObject.Find("Hantei_New"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        WallBox_B = HanB.GetComponent<Hantei_B>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!WallBox_B.getFlag())
        {
            GetComponent<Renderer>().material.mainTexture = texture2;
            GetComponent<Renderer>().material.color = Color.white;
            GetComponent<BoxCollider2D>().enabled = true;

            //Debug.Log("壁処理オン");
        }
        else if (WallBox_B.getFlag())
        {
            GetComponent<Renderer>().material.mainTexture = texture;
            GetComponent<Renderer>().material.color = Color.white;
            GetComponent<BoxCollider2D>().enabled = false;
            //Debug.Log("壁処理オフ");
        }
    }
}
