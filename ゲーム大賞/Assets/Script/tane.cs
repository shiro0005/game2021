using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tane : MonoBehaviour
{
    public GameObject tate_plant;
    public GameObject yoko_plant;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {

            GameObject plants = Instantiate(tate_plant);
            float y = tate_plant.transform.localScale.y * 0.9f;
            plants.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + y, this.transform.position.z);
            plants.transform.eulerAngles = new Vector3(0, 0, 0);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "ue")
        {

            GameObject plants = Instantiate(tate_plant);
            float y = tate_plant.transform.localScale.y * 0.5f;
            plants.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + y, this.transform.position.z);
            plants.transform.eulerAngles = new Vector3(0, 0, 0);
            Destroy(this.gameObject);

            Debug.Log("è„");
        }

        else if (collision.gameObject.tag == "migi")
        {

            GameObject plants = Instantiate(yoko_plant);
            float x = yoko_plant.transform.localScale.x * 0.5f;
            plants.transform.position = new Vector3(this.transform.position.x + x, this.transform.position.y, this.transform.position.z);
            plants.transform.eulerAngles = new Vector3(0, 0, 0);
            Destroy(this.gameObject);
            Debug.Log("âE");
        }

        else if (collision.gameObject.tag == "hidari")
        {

            GameObject plants = Instantiate(yoko_plant);
            float x = yoko_plant.transform.localScale.x * 0.5f;
            plants.transform.position = new Vector3(this.transform.position.x - x, this.transform.position.y, this.transform.position.z);
            plants.transform.eulerAngles = new Vector3(0, 0, 0);
            Destroy(this.gameObject);
            Debug.Log("ç∂");
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {

    }
}
