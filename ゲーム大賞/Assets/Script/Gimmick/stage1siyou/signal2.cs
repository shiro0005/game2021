using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signal2 : MonoBehaviour
{
    
    //public GameObject who;
    public GameObject child;
    public GameObject child2;
    public GameObject sigUI;

    bool touch=false;

    GameObject HanB;
    Hantei_B SignalBox;
    GameObject HanC;
    public float seconds;//�������N�[���^�C��

    // Start is called before the first frame update
    void Start()
    {
        HanB = GameObject.Find("Hantei_New"); 
        SignalBox = HanB.GetComponent<Hantei_B>();
        HanC = GameObject.Find("Hantei_Roll");
        child2.GetComponent<Red>().ColorChange();//�ԃI��
        child.GetComponent<Green>().NoColorChange2P();//�΃I�t
        Debug.Log("Child:" + child.name);//�q�̃��O
    }

    // Update is called once per frame
    void Update()
    {
        if (touch)
        {
            //seconds += Time.deltaTime;
            //if (who.gameObject.activeInHierarchy)
            //{
            //    if (Input.GetKey(KeyCode.K))
            //    {
            //        if (seconds >= 0.25)
            //        {
            //            SignalBox.changeFlag();
            //        }
            //    }
            //}
        }
        if(SignalBox.GetChangeFlag())
        {
            if(SignalBox.getFlag())
            {//true=�� false=��
                GreentoRed();
            }
            else if(!SignalBox.getFlag())
            {
                RedtoGreen();
            }
            else
            {
                Debug.Log("�\�����ʃG���[");
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        touch = true;
        if (col.gameObject.name == "human_1")
        {
            sigUI.GetComponent<gimisig_UI>().after2GimmickUI();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        touch = false;
        sigUI.GetComponent<gimisig_UI>().before2GimmickUI();
    }

    //public void ChangeSignal()
    //{
    //    if (who.gameObject.activeInHierarchy)
    //    {
    //        //Debug.Log("�l���̈�ɓ����Ă�");
    //        if (Input.GetKey(KeyCode.K))
    //        {
    //            if (seconds >= 0.25)
    //            {
    //                SignalBox.changeFlag();//ON�ŕ\��
    //                SignalBox2.changeFlag();//OFF�ŕ\��
    //                if (SignalBox.getFlag())
    //                {
    //                    child.GetComponent<Green>().ColorChange2P();//�΃I��
    //                    child2.GetComponent<Red>().NoColorChange();//�ԃI�t
    //                    SE.instance.PlaySE(BGM_Gim);
    //                    seconds = 0;

    //                }

    //                else if (!SignalBox.getFlag())
    //                {
    //                    child2.GetComponent<Red>().ColorChange();//�ԃI��
    //                    child.GetComponent<Green>().NoColorChange2P();//�΃I�t
    //                    SE.instance.PlaySE(BGM_Gim);
    //                    seconds = 0;
    //                }

    //                if (SignalBox2.getFlag())
    //                {

    //                    child.GetComponent<Green>().ColorChange2P();//�΃I��
    //                    child2.GetComponent<Red>().NoColorChange();//�ԃI�t
    //                    SE.instance.PlaySE(BGM_Gim);
    //                    seconds = 0;

    //                }

    //                else if (!SignalBox2.getFlag())
    //                {
    //                    child2.GetComponent<Red>().ColorChange();//�ԃI��
    //                    child.GetComponent<Green>().NoColorChange2P();//�΃I�t
    //                    SE.instance.PlaySE(BGM_Gim);
    //                    seconds = 0;
    //                }

                    
    //            }
    //        }

    //    }
    //}

    void RedtoGreen()
    {
        child.GetComponent<Green>().ColorChange2P();//�΃I��
        child2.GetComponent<Red>().NoColorChange();//�ԃI�t
        seconds = 0;
    }

    void GreentoRed()
    {
        child2.GetComponent<Red>().ColorChange();//�ԃI��
        child.GetComponent<Green>().NoColorChange2P();//�΃I�t
        seconds = 0;
    }

}
