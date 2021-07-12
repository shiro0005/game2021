using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Light : MonoBehaviour
{
    public GameObject Red_Light;
    public GameObject Green_Light;

    public bool Rflag;
    public bool Gflag;

    // Start is called before the first frame update
    void Start()
    {
        this.Red_Light.SetActive(Rflag);
        this.Green_Light.SetActive(Gflag);

        if (Rflag)
        {
            Gflag = false;
        }

        if (Rflag)
        {
            Gflag = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
