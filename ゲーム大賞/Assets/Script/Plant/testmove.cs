using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour
{
    public float power;
    public float lowPower;

    //public GameObject mouseObject;
    //Mouse mouseControl;

    public GameObject Player;

    //Player playerAction;

    private Rigidbody Prb2D;
    private Vector2 Pvec=new Vector2(0,0);

    Vector3 movePosition;
    Vector3 playerPosition;
    Vector2 addPower;



    // Start is called before the first frame update
    void Start()
    {
        //mouseControl = mouseObject.GetComponent<Mouse>();

        //playerAction = playerObject.GetComponent<Player>();
        Prb2D = Player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            Pvec.y = 1.0f;        
        }
        else
        {
            Pvec.y = 0.0f;
        }

        if (Input.GetKey(KeyCode.A)) {
            Pvec.x = -1.0f;
        }
        else if (Input.GetKey(KeyCode.D)) {
            Pvec.x = 1.0f;
        }
        else
        {
            Pvec.x = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            playerPosition = Player.transform.position;
            movePosition =new Vector3 (Player.transform.position.x + Pvec.x, Player.transform.position.y + Pvec.y,playerPosition.z);
            addPower.x = movePosition.x - playerPosition.x;
            addPower.y = movePosition.y - playerPosition.y;
            addPower = addPower.normalized;
            Prb2D.velocity = addPower * power;//速度を決める
            
            if (Vector3.Distance(playerPosition, movePosition) < 1.0)
            {
                Prb2D.velocity = Prb2D.velocity * lowPower;//速度を決める
            }
        }
        /*if (!isMove)
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerPosition = playerAction.transform.position;
                mousePosition = mouseControl.GetMousePos();
                addPower.x = mousePosition.x - playerPosition.x;
                addPower.y = mousePosition.y - playerPosition.y;
                addPower = addPower.normalized;
                //playerAction.rb.AddForce(addPower * power);// 力を加える
                isMove = true;
            }
        }
        if (isMove)
        {
            playerAction.rb.velocity = (addPower * power);//速度を決める
            Vector3 nowPlayerPosition = playerAction.transform.position;
            if (Vector3.Distance(nowPlayerPosition, mousePosition) < 1.0)
            {
                playerAction.rb.velocity = playerAction.rb.velocity * lowPower;//速度を決める
                isMove = false;
            }
        }*/
    }
}