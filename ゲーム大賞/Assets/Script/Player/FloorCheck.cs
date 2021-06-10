using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCheck : MonoBehaviour
{
    private string graundTag = "Floor";
    private bool isGround = false;
    private bool isGroundEnter, isGroundStay, isGroundExit;


    public bool IsGround()
    {
        if (isGroundStay || isGroundEnter)
        {
            isGround = true;
        }
        else if (isGroundExit)
        {
            isGround = false;
        }
        isGroundStay = false;
        isGroundEnter = false;
        isGroundExit = false;

        return isGround;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == graundTag)
        {
            //Debug.Log("�n�ʂɓ�������");
            isGroundEnter = true;
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == graundTag)
        {
            //Debug.Log("�n�ʂɓ������Ă�");
            isGroundStay = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == graundTag)
        {
            //Debug.Log("�n�ʂ��甲���o����");
            isGroundExit = true;
        }
    }
}
