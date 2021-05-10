using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seed : MonoBehaviour
{
    
    public GameObject Ivy;
    public Transform Ivyspawn;
    private bool Judge = true;

    // Start is called before the first frame update
    
    void OnCollisionEnter(Collision collision) {
        if (Judge) 
        {
            GameObject newIvy = Instantiate(Ivy, Ivyspawn.position, Quaternion.identity) as GameObject;
            Judge = false;
        }
      
       
    }


}
