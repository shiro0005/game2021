using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal : MonoBehaviour
{
    [SerializeField]GameObject Human;
    GameObject[] OnOffBrock;                                            //親オブジェクト
    private List<GameObject> OnOffBrock_Child = new List<GameObject>(); //子オブジェクト
    public bool Touch = false;

    // Start is called before the first frame update
    void Start()
    {
        OnOffBrock = GameObject.FindGameObjectsWithTag("Floor_Gimmick");
        foreach (var item in OnOffBrock)
        {
            OnOffBrock_Child.Add(item.transform.GetChild(0).gameObject);

            if (item.GetComponent<OnOffBrock>().GetFlag())  //通れる
            {
                item.GetComponent<SpriteRenderer>().enabled = false;
                item.GetComponent<BoxCollider2D>().enabled = true;
                item.transform.GetChild(0).gameObject.SetActive(true);
            }
            else　　　                                      //通れない
            {
                item.GetComponent<SpriteRenderer>().enabled = true;
                item.GetComponent<BoxCollider2D>().enabled = false;
                item.transform.GetChild(0).gameObject.SetActive(false);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Touch)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                int Count = 0;
                foreach (var item in OnOffBrock)
                {
                    if (item.GetComponent<SpriteRenderer>().enabled == true)
                    {
                        item.GetComponent<SpriteRenderer>().enabled = false;
                        item.GetComponent<BoxCollider2D>().enabled = true;
                        OnOffBrock_Child[Count].SetActive(true);
                        Count++;
                    }
                    else
                    {
                        item.GetComponent<SpriteRenderer>().enabled = true;
                        item.GetComponent<BoxCollider2D>().enabled = false;
                        OnOffBrock_Child[Count].SetActive(false);
                        Count++;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Human)
        {
            Touch = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Human)
        {
            Touch = false;
        }
    }
}
