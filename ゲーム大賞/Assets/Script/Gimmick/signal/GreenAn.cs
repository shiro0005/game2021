using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnotherColorChange2P()
    {
        GetComponent<Renderer>().material.color = new Color32(0, 255, 0, 1);
    }

    public void AnotherNoColorChange2P()
    {
        GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 1);
    }
}
