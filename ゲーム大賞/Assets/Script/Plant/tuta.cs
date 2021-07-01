using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuta : MonoBehaviour
{
    private Vector2 Pvec = new Vector2(0, 0);//ツタ移動用
    private float ls = 1.75f;//ツタ伸ばす量（速度）
    private int Flag = 0;
    private void Update()
    {
        // Growup(-90.0f);
    }

    // Update is called once per frame
    public void Growup(float z)
    {
        // x += 0.01f;
        if (z == 0)
        {
            Pvec.x = -0.02f;
            Pvec.y = 0.10f;
        }
        else if (z == 45)
        {
            Pvec.x = -0.25f*Mathf.Sin(45f * Mathf.Deg2Rad);
            Pvec.y = 0.25f * Mathf.Cos(45f * Mathf.Deg2Rad);
        }
        else if (z == 90)
        {
            Pvec.x = -0.2f * Mathf.Sin(90f * Mathf.Deg2Rad);
            Pvec.y = 0.2f * Mathf.Cos(90f * Mathf.Deg2Rad);
        }
        else if (z == -45)
        {
            Pvec.x = -0.25f * Mathf.Sin(-45f * Mathf.Deg2Rad);
            Pvec.y = 0.25f * Mathf.Cos(-45f * Mathf.Deg2Rad);
        }
        else if (z == -90)
        {
            Pvec.x = -0.2f * Mathf.Sin(-90f * Mathf.Deg2Rad);
            Pvec.y = 0.2f * Mathf.Cos(-90f * Mathf.Deg2Rad);
        }
        Quaternion tlr = this.transform.localRotation;
       
        this.transform.localPosition = new Vector3(this.transform.localPosition.x+Pvec.x* Time.deltaTime, this.transform.localPosition.y+Pvec.y*Time.deltaTime, this.transform.localPosition.z);
        this.transform.localScale = new Vector3(this.transform.localScale.x+Time.deltaTime, this.transform.localScale.y +ls*Time.deltaTime, this.transform.localScale.z);
        this.transform.localRotation = Quaternion.Euler(0, 0,-30);
    }

    public void Growdown(float z)
    {
        // x += 0.01f;
        if (z == 0)
        {
            Pvec.x = +0.02f;
            Pvec.y = -0.10f;
        }
        else if (z == 45)
        {
            Pvec.x = 0.25f * Mathf.Sin(45f * Mathf.Deg2Rad);
            Pvec.y = -0.25f * Mathf.Cos(45f * Mathf.Deg2Rad);
        }
        else if (z == 90)
        {
            Pvec.x = 0.2f * Mathf.Sin(90f * Mathf.Deg2Rad);
            Pvec.y = -0.2f * Mathf.Cos(90f * Mathf.Deg2Rad);
        }
        else if (z == -45)
        {
            Pvec.x = 0.25f * Mathf.Sin(-45f * Mathf.Deg2Rad);
            Pvec.y = -0.25f * Mathf.Cos(-45f * Mathf.Deg2Rad);
        }
        else if (z == -90)
        {
            Pvec.x = 0.2f * Mathf.Sin(-90f * Mathf.Deg2Rad);
            Pvec.y = -0.2f * Mathf.Cos(-90f * Mathf.Deg2Rad);
        }
        Quaternion tlr = this.transform.localRotation;

        this.transform.localPosition = new Vector3(this.transform.localPosition.x + Pvec.x * Time.deltaTime, this.transform.localPosition.y + Pvec.y * Time.deltaTime, this.transform.localPosition.z);
        this.transform.localScale = new Vector3(this.transform.localScale.x - Time.deltaTime, this.transform.localScale.y - ls * Time.deltaTime, this.transform.localScale.z);
        this.transform.localRotation = Quaternion.Euler(0, 0,-30);
    }
    public void GrowReset()
    {
        this.transform.localPosition = new Vector3(0f, -0.035f, 0f);
        this.transform.localScale = new Vector3(0.05f, 0.05f, 0.0001f);
        this.transform.localRotation = Quaternion.Euler(0, 0, -30);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plant")
        {
            Flag = 1;
        }
        else if (collision.gameObject.tag != "Player")
        {
            Flag = 2;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        Flag = 0;
    }

    public float GetScale()
    {
        return this.transform.localScale.y;
    }

    public int GetFlag()
    {
        return Flag;
    }
}
