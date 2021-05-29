using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signal3 : MonoBehaviour
{
    public GameObject who;
    GameObject havescript1;//別のscから関数を呼ぶ
    GameObject havescript2;
    public GameObject sigUI;
    public AudioClip BGM_Gim;

    bool touch = false;

    GameObject HanC;
    Hantei_C SignalBox;
    public float seconds;//お試しクールタイム

    // Start is called before the first frame update
    void Start()
    {
        HanC = GameObject.Find("Hantei_Roll");
        SignalBox = HanC.GetComponent<Hantei_C>();
        havescript1 = GameObject.Find("redAN");
        havescript2 = GameObject.Find("greenAN");
        havescript1.GetComponent<RedAn>().AnotherColorChange();//赤オン
        havescript2.GetComponent<GreenAn>().AnotherNoColorChange2P();//緑オフ
    }

    // Update is called once per frame
    void Update()
    {
        if (touch)
        {
            seconds += Time.deltaTime;
            ChangeSignal();
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        touch = true;
        if (col.gameObject.name == "human_1")
        {
            sigUI.GetComponent<gimisig_UI>().after2GimmickUI();
        }
        Debug.Log("Rollのシグナルの範囲入ってる");
    }

    void OnTriggerExit2D(Collider2D col)
    {
        sigUI.GetComponent<gimisig_UI>().before2GimmickUI();
        touch = false;
    }

    void ChangeSignal()
    {
        if (who.gameObject.activeInHierarchy)
        {

            //Debug.Log("人が領域に入ってる");
            if (Input.GetKey(KeyCode.K))
            {
                if (seconds >= 0.25)
                {
                    SignalBox.changeFlag();

                    if (SignalBox.getFlag())
                    {

                        havescript2.GetComponent<GreenAn>().AnotherColorChange2P();//緑オン
                        havescript1.GetComponent<RedAn>().AnotherNoColorChange();//赤オフ
                        SE.instance.PlaySE(BGM_Gim);
                        seconds = 0;

                    }


                    else if (!SignalBox.getFlag())
                    {
                        havescript1.GetComponent<RedAn>().AnotherColorChange();//赤オン
                        havescript2.GetComponent<GreenAn>().AnotherNoColorChange2P();//緑オフ
                        SE.instance.PlaySE(BGM_Gim);
                        seconds = 0;
                    }
                }
            }

        }
    }
}