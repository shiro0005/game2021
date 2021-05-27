using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ColorChange2P()
    {
        GetComponent<Renderer>().material.color = new Color32(0, 255, 0, 1);
    }

    public void NoColorChange2P()
    {
        GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 1);
    }
}
