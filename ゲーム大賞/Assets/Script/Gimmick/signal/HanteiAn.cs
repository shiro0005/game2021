using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanteiAn : MonoBehaviour
{
    GameObject havescript1;//別のscから関数を呼ぶ
    GameObject havescript2;
    public GameObject havescript3;

    public GameObject who;
    bool awake;

    public float ANseconds;//お試しクールタイム

    // Start is called before the first frame update
    void Start()
    {
        havescript1 = GameObject.Find("redAN");
        havescript2 = GameObject.Find("greenAN");
        havescript3 = GameObject.Find("wing");
        awake = false;
        havescript1.GetComponent<RedAn>().AnotherColorChange();
        havescript2.GetComponent<GreenAn>().AnotherNoColorChange2P();
        havescript3.GetComponent<Roller>().ActionPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "Target")
        {
            if (who.gameObject.activeInHierarchy)
            {

                Debug.Log("人が触れてる");
                if (awake == true)
                {
                    ANseconds += Time.deltaTime;
                    if (ANseconds >= 0.75)
                    {
                        if (Input.GetKey(KeyCode.E))
                        {
                            //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                            havescript2.GetComponent<GreenAn>().AnotherColorChange2P();
                            havescript1.GetComponent<RedAn>().AnotherNoColorChange();
                            havescript3.GetComponent<Roller>().SilentPosition();
                            awake = false;
                            ANseconds = 0;
                        }
                    }
                }
                else if (awake == false)
                {
                    ANseconds += Time.deltaTime;
                    if (ANseconds >= 0.75)
                    {
                        if (Input.GetKey(KeyCode.E))
                        {
                            //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                            havescript1.GetComponent<RedAn>().AnotherColorChange();
                            havescript2.GetComponent<GreenAn>().AnotherNoColorChange2P();
                            havescript3.GetComponent<Roller>().ActionPosition();
                            awake = true;
                            ANseconds = 0;
                        }
                    }
                }
            }
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Target")
        {
            if (who.gameObject.activeInHierarchy)
            {
                Debug.Log("人が離れた");
                ANseconds = 0;
                //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                //havescript1.GetComponent<Red>().ColorChange();
                //havescript2.GetComponent<Green>().NoColorChange2P();
            }
        }
    }
}
