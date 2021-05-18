using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour
{
    public float power;
    public float lowPower;

    public GameObject mouseObject;
    //Mouse mouseControl;

    //public GameObject playerObject;
    //Player playerAction;

    //Rigidbody2D Prb2D;

    //Vector3 mousePosition;
    //Vector3 playerPosition;
    //Vector2 addPower;

    //bool isMove = false;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    mouseControl = mouseObject.GetComponent<Mouse>();

    //    playerAction = playerObject.GetComponent<Player>();
    //    Prb2D = playerAction.rb;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (!isMove)
    //    {
    //        if (Input.GetMouseButtonDown(0))
    //        {
    //            playerPosition = playerAction.transform.position;
    //            mousePosition = mouseControl.GetMousePos();

    //            addPower.x = mousePosition.x - playerPosition.x;
    //            addPower.y = mousePosition.y - playerPosition.y;
    //            addPower = addPower.normalized;
    //            //playerAction.rb.AddForce(addPower * power);// —Í‚ð‰Á‚¦‚é

    //            isMove = true;
    //        }
    //    }

    //    if (isMove)
    //    {
    //        playerAction.rb.velocity = (addPower * power);//‘¬“x‚ðŒˆ‚ß‚é

    //        Vector3 nowPlayerPosition = playerAction.transform.position;

    //        if (Vector3.Distance(nowPlayerPosition, mousePosition) < 1.0)
    //        {
    //            playerAction.rb.velocity = playerAction.rb.velocity * lowPower;//‘¬“x‚ðŒˆ‚ß‚é
    //            isMove = false;
    //        }
    //    }
    //}
}