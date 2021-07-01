using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Germination : MonoBehaviour
{
    public GameObject plant;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            //ê∂Ç¶ÇƒÇ≠ÇÈí”ÇÃê›íË
            GameObject plants = Instantiate(plant);
            float y =plant.transform.localScale.y*0.9f;
            float x = plant.transform.localScale.x * 1.2f;
            plants.transform.position = new Vector3(this.transform.position.x-x, this.transform.position.y+1.25f , this.transform.position.z);
            plants.transform.eulerAngles = new Vector3(0, 180, -45);
            plants.transform.localScale = new Vector3(70,70,50);//å≥ÇÃêîíl70,70,50
            Destroy(this.gameObject);
        }
   
    }
}
