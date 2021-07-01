using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneseniGoal : MonoBehaviour
{
    public int m_scene;
    private static bool Flag = false;
    public AudioClip transitionSE;

    private float step_time;
    private bool goalCount = false;
    public GameObject Text;

    private void Start()
    {
        Text.SetActive(false);
        step_time = 0.0f;

        Flag = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneTransition.Nextscene(m_scene);
            Flag = true;
        }
        if (goalCount == true)
        {
            //テキスト表示
            Text.SetActive(true);

            step_time += Time.deltaTime;

            if (step_time >= 3.0f)
            {

                SE.instance.PlaySE(transitionSE);
                SceneTransition.Nextscene(m_scene);
                Flag = true;



                goalCount = false;
                step_time = 0.0f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !Flag)
        {
            goalCount = true;
        }
    }


}

