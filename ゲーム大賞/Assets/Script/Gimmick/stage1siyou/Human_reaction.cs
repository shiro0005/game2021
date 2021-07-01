using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_reaction : MonoBehaviour
{

    public GameObject who;
    public GameObject Gim_UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (who.gameObject.activeInHierarchy)
        {
            if (col.gameObject.name == "human_1")
            {
                //Debug.Log("凡人が入っていますわよー");
                Gim_UI.GetComponent<gimibox_UI>().afterGimmickUI();
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (who.gameObject.activeInHierarchy)
        {
            //Debug.Log("凡人が逃げましたわよー");
            Gim_UI.GetComponent<gimibox_UI>().beforeGimmickUI();
        }

    }
}
