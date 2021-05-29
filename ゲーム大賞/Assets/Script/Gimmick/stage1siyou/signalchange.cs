using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signalchange : MonoBehaviour
{
    GameObject havescript1;//別のscから関数を呼ぶ
    GameObject havescript2;
    public GameObject child;
    public GameObject child2;

    public GameObject who;
    bool awake;

    public float seconds;//お試しクールタイム

    // Start is called before the first frame update
    void Start()
    {
        havescript1 = GameObject.Find("red");
        havescript2 = GameObject.Find("green");
        awake = false;
        havescript1.GetComponent<Red>().ColorChange();//赤オン
        havescript2.GetComponent<Green>().NoColorChange2P();//緑オフ

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if (who.gameObject.activeInHierarchy)
            {
                Debug.Log("人が領域に入ってる");
                if (awake == true)
                {
                    seconds += Time.deltaTime;
                    if (seconds >= 0.25)
                    {
                        if (Input.GetKey(KeyCode.K))
                        {
                            //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                            havescript2.GetComponent<Green>().ColorChange2P();//緑オン
                            havescript1.GetComponent<Red>().NoColorChange();//赤オフ
                            int count = 0;//onブロック用
                            int count2 = 0;//offブロック用
                            foreach (Transform child in transform)
                            {
                                Debug.Log("Child[" + count + "]:" + child.name);
                                child.GetComponent<skellton>().WallAlfaCri();//コリュジョン諸々を付ける
                                count++;
                                
                            }
                            foreach (Transform child2 in transform)
                            {
                                Debug.Log("Child[" + count2 + "]:" + child2.name);
                                child2.GetComponent<skellton2>().WallBetaDes();//コリュジョン諸々を消す
                                count2++;
                            }
                            awake = false;
                            seconds = 0;
                        }
                    }
                }
                else if (awake == false)
                {
                    seconds += Time.deltaTime;
                    if (seconds >= 0.25)
                    {
                        if (Input.GetKey(KeyCode.K))
                        {
                            //関数呼び出し、エラー時や挙動がおかしい場合一時避難推奨
                            havescript1.GetComponent<Red>().ColorChange();//赤オン
                            havescript2.GetComponent<Green>().NoColorChange2P();//緑オフ
                            int count = 0;
                            int count2 = 0;
                            foreach (Transform child in transform)
                            {
                                Debug.Log("Child[" + count + "]:" + child.name);
                                child.GetComponent<skellton>().WallAlfaDes();//コリュジョン諸々を消す
                                count++;
                                
                            }
                            foreach (Transform child2 in transform)
                            {
                                Debug.Log("Child[" + count2 + "]:" + child2.name);
                                child2.GetComponent<skellton2>().WallBetaCri();//コリュジョン諸々を付ける
                                count2++;
                                
                            }
                            awake = true;
                            seconds = 0;
                        }
                    }
                }
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
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
