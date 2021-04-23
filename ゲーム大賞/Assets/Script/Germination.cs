using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Germination : MonoBehaviour
{
    public GameObject plant;
   
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            
            GameObject plants = Instantiate(plant) as GameObject;
            plants.transform.position = new Vector3(this.transform.position.x+1.0f, this.transform.position.y-0.145f, this.transform.position.z);
            plants.transform.eulerAngles = new Vector3(0,0,-90);
            Destroy(this.gameObject);
        }
    }
}
