using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signal2 : MonoBehaviour
{
    
    public GameObject who;
    public GameObject me;
    public GameObject child;
    public GameObject child2;

    bool touch=false;

    GameObject HanB;
    Hantei_B SignalBox;
    GameObject HanC;
    Hantei_C SignalBox2;
    public float seconds;//お試しクールタイム

    // Start is called before the first frame update
    void Start()
    {
        HanB = GameObject.Find("Hantei"); 
        SignalBox = HanB.GetComponent<Hantei_B>();
        HanC = GameObject.Find("Hantei_Roll");
        SignalBox2 = HanC.GetComponent<Hantei_C>();

        child2.GetComponent<Red>().ColorChange();//赤オン
        child.GetComponent<Green>().NoColorChange2P();//緑オフ
        Debug.Log("Child:" + child.name);//子のログ
    }

    // Update is called once per frame
    void Update()
    {
        if (touch)
        {
            seconds += Time.deltaTime;
            //ChangeSignal();
            me.GetComponent<signal2>().ChangeSignal();
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        touch = true;
        Debug.Log("あたっている");
    }

    void OnTriggerExit2D(Collider2D col)
    {
        touch = false;
    }

    void ChangeSignal()
    {
        if (who.gameObject.activeInHierarchy)
        {

            Debug.Log("人が領域に入ってる");
            if (Input.GetKey(KeyCode.E))
            {
                if (seconds >= 0.25)
                {
                    SignalBox.changeFlag();
                    SignalBox2.changeFlag();
                    if (SignalBox.getFlag())
                    {
                        child.GetComponent<Green>().ColorChange2P();//緑オン
                        child2.GetComponent<Red>().NoColorChange();//赤オフ
                        seconds = 0;

                    }

                    else if (!SignalBox.getFlag())
                    {
                        child2.GetComponent<Red>().ColorChange();//赤オン
                        child.GetComponent<Green>().NoColorChange2P();//緑オフ
                        seconds = 0;
                    }

                    if (SignalBox2.getFlag())
                    {

                        child.GetComponent<Green>().ColorChange2P();//緑オン
                        child2.GetComponent<Red>().NoColorChange();//赤オフ
                        seconds = 0;

                    }

                    else if (!SignalBox2.getFlag())
                    {
                        child2.GetComponent<Red>().ColorChange();//赤オン
                        child.GetComponent<Green>().NoColorChange2P();//緑オフ
                        seconds = 0;
                    }

                    
                }
            }

        }
    }
}
