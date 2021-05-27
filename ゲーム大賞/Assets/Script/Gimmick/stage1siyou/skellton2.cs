using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skellton2 : MonoBehaviour
{
    Rigidbody rb;
    bool flag;
    public Texture texture;
    public Texture texture2;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        rb = this.GetComponent<Rigidbody>();

        GetComponent<BoxCollider2D>().enabled = false;
        color = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.mainTexture = texture;
        GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Changeee()
    {
        if (flag == true)
        {
            WallBetaCri();
        }

        if (flag == false)
        {
            WallBetaDes();
        }
    }

    public void WallBetaCri()
    {
        flag = false;
        GetComponent<Renderer>().material.mainTexture = texture2;
        GetComponent<Renderer>().material.color = Color.white;
        GetComponent<BoxCollider2D>().enabled = true;
        Debug.Log("ï«èàóùÉIÉì");
    }

    public void WallBetaDes()
    {
        flag = true;
        GetComponent<Renderer>().material.mainTexture = texture;
        GetComponent<Renderer>().material.color = Color.white;
        GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("ï«èàóùÉIÉt");
    }
}
