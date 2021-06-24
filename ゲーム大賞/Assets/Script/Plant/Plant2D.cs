using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant2D : MonoBehaviour
{
    [SerializeField] GameObject Seed;//飛ばす種

    //移動に使う力
    private float power = 40.0f;
    private float lowPower = 1.0f;

    public GameObject Player;//プレイヤー
    public GameObject child;//plantの子オブジェクトを設定

    private Rigidbody2D Prb2D;//プレイヤーのリキッドボディを入れる
    private Vector2 Pvec = new Vector2(0, 0);//移動のベクトル
    private Vector2 PvecData = new Vector2(0, 0);//移動ベクトル保存用

    private Vector2 movePosition;//目的地
    private Vector2 playerPosition;//現在地
    private Vector2 addPower;//必要な力（計算用）
    private float angle = 0;//ツタ伸ばしの角度
 

    private int flag = 0;//ケース用

    private Animator animator;

    public AudioClip plantingSE;
    public AudioClip growupSE;
    public AudioClip moveSE;

    // Start is called before the first frame update
    void Start()
    {
        Prb2D = Player.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //キー入力判定
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

        if (Input.GetKeyDown(KeyCode.Space)&&flag==0)
        {
            if (Pvec.x != 0.0f || Pvec.y != 0.0f)
            {
                flag = 1;
                PvecData = Pvec;
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("isPlanting", true);
            
            this.GetComponent<Planting>().Plant(Pvec.x, Pvec.y, Seed, Player.transform);//種飛ばし
            SE.instance.PlaySE(plantingSE);
        }
        else
        {
            animator.SetBool("isPlanting", false);
        }

        switch (flag)
        {
            case 0:
                break;

            case 1:
                
                //角度設定
                if (PvecData.x == 1.0f)
                {
                    angle = 90f;
                    if (PvecData.y == 1.0f)
                    {
                        angle = 45f;
                    }
                }
                else if (PvecData.x == -1.0f)
                {
                    angle = -90f;
                    if (PvecData.y == 1.0f)
                    {
                        angle = -45f;
                    }
                }

                //ツタ伸ばし
                child.GetComponent<tuta>().Growup(angle);
                SE.instance.PlaySE(growupSE);

                if (child.GetComponent<tuta>().GetScale()> 0.25f)//ツタ限界
                {
                    flag = 2;
                }
                else if (child.GetComponent<tuta>().GetFlag() == 1)//ツタがつかめる
                {
                    flag = 4;
                }
                else if (child.GetComponent<tuta>().GetFlag() == 2)//ツタがオブジェクトにぶつかり戻る
                {
                    flag = 2;
                }
                break;

            case 2:
                //ツタ戻し
                child.GetComponent<tuta>().Growdown(angle);


                if(child.GetComponent<tuta>().GetScale() <= 0.003f)//ツタ元通り
                {
                    flag = 3;
                }
                break;

            case 3:
                angle = 0.0f;//元通り
                flag = 0;
                child.GetComponent<tuta>().GrowReset();
                break;

            case 4:
                //Plant移動処理
                playerPosition = Player.transform.position;
                movePosition = new Vector2(Player.transform.position.x + PvecData.x, Player.transform.position.y + PvecData.y);
                addPower.x = movePosition.x - playerPosition.x;
                addPower.y = movePosition.y - playerPosition.y;
                addPower = addPower.normalized;
                Prb2D.velocity = addPower * power;//速度を決める

                if (Vector2.Distance(playerPosition, movePosition) < 1.0)
                {
                    Prb2D.velocity = Prb2D.velocity * lowPower;//速度を決める
                }
                SE.instance.PlaySE(moveSE);
                flag = 2;
                break;
            default:
                break;
        }
    }
}
