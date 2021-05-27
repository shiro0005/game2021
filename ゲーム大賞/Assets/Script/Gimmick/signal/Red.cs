using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ColorChange()
    {
        GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 1);
    }
    public void NoColorChange()
    {
        GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 1);
    }
}
