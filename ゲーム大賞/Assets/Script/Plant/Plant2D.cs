using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant2D : MonoBehaviour
{
    [SerializeField] GameObject Seed;

    private float power=10.0f;
    private float lowPower=1.0f;

    public GameObject Player;

    private Rigidbody2D Prb2D;
    private Vector2 Pvec = new Vector2(0, 0);

    private Vector2 movePosition;
    private Vector2 playerPosition;
    private Vector2 addPower;

    private Planting planting;


    // Start is called before the first frame update
    void Start()
    {
        //mouseControl = mouseObject.GetComponent<Mouse>();

        //playerAction = playerObject.GetComponent<Player>();
        Prb2D = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Pvec.y = 1.0f;
        }
        else
        {
            Pvec.y = 0.0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Pvec.x = -1.0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Pvec.x = 1.0f;
        }
        else
        {
            Pvec.x = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Pvec.x != 0.0f || Pvec.y != 0.0f)
            {
                playerPosition = Player.transform.position;
                movePosition = new Vector2(Player.transform.position.x + Pvec.x, Player.transform.position.y + Pvec.y);
                addPower.x = movePosition.x - playerPosition.x;
                addPower.y = movePosition.y - playerPosition.y;
                addPower = addPower.normalized;
                Prb2D.velocity = addPower * power;//‘¬“x‚ðŒˆ‚ß‚é

                if (Vector2.Distance(playerPosition, movePosition) < 1.0)
                {
                    Prb2D.velocity = Prb2D.velocity * lowPower;//‘¬“x‚ðŒˆ‚ß‚é
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.GetComponent<Planting>().Plant(Pvec.x,Pvec.y,Seed, Player.transform);
            
        }
    }
}
