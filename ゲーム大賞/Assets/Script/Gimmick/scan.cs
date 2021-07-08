using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scan : MonoBehaviour
{
    GameObject HanB;
    Hantei_B SignalBox;

    // Start is called before the first frame update
    void Start()
    {
        HanB = GameObject.Find("Hantei");

        SignalBox = HanB.GetComponent<Hantei_B>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            SignalBox.changeFlag();
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "human_1")
        {
            SignalBox.changeFlag();
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
    }
}
