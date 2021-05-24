using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnotherColorChange()
    {
        GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 1);
    }
    public void AnotherNoColorChange()
    {
        GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 1);
    }
}
