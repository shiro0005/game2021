using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{

    public Vector2 direction;
    public Vector2 down;
    bool Oneflag;//ドアの開閉判定用

    // Start is called before the first frame update
    void Start()
    {
        Oneflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Oneflag == true)
        {
            DoirOpen1();
        }

        if (Oneflag == false)
        {
            DoirClose1();
        }
    }

    public void DoirOpen1()
    {
        Oneflag = true;

        this.transform.position = direction;

    }

    public void DoirClose1()
    {
        Oneflag = false;

        this.transform.position = down;

    }
}
