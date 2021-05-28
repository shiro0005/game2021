using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class number : MonoBehaviour
{
    public GameObject Death_CC;

    public Image image;

    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;

    int a, b = 0;

    // Start is called before the first frame update
    void Start()
    {
        a = Death_CC.GetComponent<Death_CC>().GetZanki();
        ChengNum(a);
    }

    // Update is called once per frame
    void Update()
    {
        a = Death_CC.GetComponent<Death_CC>().GetZanki();

        if (b != a)
        {
            ChengNum(a);
        }

        b = a;
    }

    void ChengNum(int Point)
    {
        Debug.Log("ŒÄ‚Î‚ê‚½‚æ");
        Point = Point % 10;
        switch (Point)
        {
            case 0:
                image = this.GetComponent<Image>();
                image.sprite = sprite0;
                break;

            case 1:
                image = this.GetComponent<Image>();
                image.sprite = sprite1;
                break;

            case 2:
                image = this.GetComponent<Image>();
                image.sprite = sprite2;
                break;

            case 3:
                image = this.GetComponent<Image>();
                image.sprite = sprite3;
                break;

            case 4:
                image = this.GetComponent<Image>();
                image.sprite = sprite4;
                break;

            case 5:
                image = this.GetComponent<Image>();
                image.sprite = sprite5;
                break;

            case 6:
                image = this.GetComponent<Image>();
                image.sprite = sprite6;
                break;

            case 7:
                image = this.GetComponent<Image>();
                image.sprite = sprite7;
                break;

            case 8:
                image = this.GetComponent<Image>();
                image.sprite = sprite8;
                break;

            case 9:
                image = this.GetComponent<Image>();
                image.sprite = sprite9;
                break;
        }

    }

}
