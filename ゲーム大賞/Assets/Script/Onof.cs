using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onof : MonoBehaviour
{
    public GameObject human;
    public GameObject animal;
    public GameObject plant;

    public float cool;

    bool Hflag;
    bool Aflag;
    bool Pflag;

    // Start is called before the first frame update
    void Start()
    {
        Hflag = false;
        Aflag = true;
        Pflag = false;

        this.human.SetActive(Hflag);
        this.animal.SetActive(Aflag);
        this.plant.SetActive(Pflag);

    }

    // Update is called once per frame
    void Update()
    {
        if (Hflag == true)
        {
            //Qキーを押す
            if (Input.GetKeyDown(KeyCode.Q))
            {
                //表示→非表示
                Hflag = false;
                Aflag = true;
            }
        }

        else if (Aflag == true)
        {
                //Qキーを押す
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Aflag = false;
                    Pflag = true;
                }   
        }

        else if (Pflag == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                    Pflag = false;
                    Hflag = true;
            }
        }

        this.human.SetActive(Hflag);//人無し
        this.animal.SetActive(Aflag);//動物有り
        this.plant.SetActive(Pflag);//植物有り
    }
}


