using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuta : MonoBehaviour
{
    private void Update()
    {
        Growup();
    }

    // Update is called once per frame
    public void Growup()
    {
        Vector3 tmp =this.transform.localScale;

        this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y + 0.001f, this.transform.localScale.z);
    }
}
