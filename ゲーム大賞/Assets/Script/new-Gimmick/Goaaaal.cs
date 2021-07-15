using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goaaaal : MonoBehaviour
{
    [SerializeField] GameObject Canvas; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "soccer_ball")
        {
            
        }
    }
}
