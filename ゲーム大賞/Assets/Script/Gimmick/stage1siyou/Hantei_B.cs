using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantei_B : MonoBehaviour
{
    public bool Flag;
    public bool ChangeFlag=false;
    public float seconds;//お試しクールタイム
    public AudioClip BGM_Gim;

    //public GameObject child;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 0.25)
            ChangeFlag = false;
    }

    public void changeFlag()
    {
            if (Flag)
            {
                Flag = false;
            SE.instance.PlaySE(BGM_Gim);
            seconds = 0;
        }
            else if (!Flag)
            {
                Flag = true;
            SE.instance.PlaySE(BGM_Gim);
            seconds = 0;
        }

        ChangeFlag = true;

    }
    public bool getFlag()
    {
        return Flag;
    }

    public bool GetChangeFlag()
    {
        return ChangeFlag;
    }

}
