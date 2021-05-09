using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ivy : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    public float Ivelong = 50.0f;
    void Start()
    {
        StartCoroutine("extend");
    }

    void Update()
    {
        
    }

    IEnumerator extend()
    {
        for (int i = 0; i < Ivelong; i++)
        {
            transform.localScale += new Vector3(0, -0.01f, 0);
            yield return new WaitForSeconds(0.01F);
        }
    }
}