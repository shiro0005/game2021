using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tere : MonoBehaviour
{
    public GameObject who;
    public GameObject WarpPoint;
    public Vector3 warp;
    // Start is called before the first frame update
    void Start()
    {
        warp = WarpPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "Target")
        {
            if (who.gameObject.activeInHierarchy)
            {
                Debug.Log("êlÇ™êGÇÍÇƒÇÈ");
                if (Input.GetKey(KeyCode.E))
                {
                    //transform.position = warp;
                    col.gameObject.transform.position = warp;
                }
            }
        }
    }
}
