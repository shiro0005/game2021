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
            Debug.Log("yukakkaakka");
            GameObject plants = Instantiate(plant) as GameObject;
            plants.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.0f, this.transform.position.z);
            Destroy(this.gameObject);
        }
    }
}
