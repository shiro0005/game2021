using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantei_B : MonoBehaviour
{
    public bool Flag;
    //public GameObject child;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void changeFlag()
    {
            if (Flag)
            {
                Flag = false;
            }
            else if (!Flag)
            {
                Flag = true;

            }
    }
    public bool getFlag()
    {
        return Flag;
    }

}
