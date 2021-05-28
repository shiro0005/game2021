using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller_B : MonoBehaviour
{
    public float Ti;
    public float Su;

    GameObject HanC;
    Hantei_C RollBox;

    // Start is called before the first frame update
    void Start()
    {
        HanC = GameObject.Find("Hantei_Roll"); 
        RollBox = HanC.GetComponent<Hantei_C>();
        transform.rotation = Quaternion.Euler(0, 0, Su);
    }

    // Update is called once per frame
    void Update()
    {
        if (RollBox.getFlag())
        {
            transform.rotation = Quaternion.Euler(0, 0, Ti);
            //GetComponent<BoxCollider2D>().enabled = false;
            //Debug.Log("ï«èàóùÉIÉì");
        }
        else if (!RollBox.getFlag())
        {
            transform.rotation = Quaternion.Euler(0, 0, Su);
            GetComponent<BoxCollider2D>().enabled = true;
            //Debug.Log("ï«èàóùÉIÉt");
        }
    }
}
