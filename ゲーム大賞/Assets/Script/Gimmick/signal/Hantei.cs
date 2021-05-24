using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantei : MonoBehaviour
{
    GameObject havescript1;//別のscから関数を呼ぶ
    GameObject havescript2;
    public GameObject havescript3;

    public GameObject who;
    bool awake;

    public float seconds;//お試しクールタイム

    // Start is called before the first frame update
    void Start()
    {
        havescript1 = GameObject.Find("red");
        havescript2 = GameObject.Find("green");
        havescript3 = GameObject.Find("wall");
        awake = false;
        havescript1.GetComponent<Red>().ColorChange();
        havescript2.GetComponent<Green>().NoColorChange2P();
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
                    seconds += Time.deltaTime;
                    if (seconds >= 0.5)
                    {
                        

                        if (Input.GetKey(KeyCode.E))
                        {
                            //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                            havescript2.GetComponent<Green>().ColorChange2P();
                            havescript1.GetComponent<Red>().NoColorChange();
                            havescript3.GetComponent<wall>().WallAlfaCri();
                            awake = false;
                            seconds = 0;
                        }
                    }
                }
                else if (awake == false)
                {
                    seconds += Time.deltaTime;
                    if (seconds >= 0.5)
                    {
                        if (Input.GetKey(KeyCode.E))
                        {
                            //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                            havescript1.GetComponent<Red>().ColorChange();
                            havescript2.GetComponent<Green>().NoColorChange2P();
                            havescript3.GetComponent<wall>().WallAlfaDes();
                            awake = true;
                            seconds = 0;
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
                //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                //havescript1.GetComponent<Red>().ColorChange();
                //havescript2.GetComponent<Green>().NoColorChange2P();
                seconds = 0;
            }
        }
    }
}
