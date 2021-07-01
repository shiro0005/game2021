using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimisig_UI : MonoBehaviour
{
    public Texture texture;
    public Texture texture2;

    public Player player;

    bool Check_Human;
    //bool texSwitch;

    // Start is called before the first frame update
    void Start()
    {
        //texSwitch = false;
    }

    // Update is called once per frame
    void Update()
    {
        Check_Human = player.CheckHuman();

        if (Check_Human)
        {
            after2GimmickUI();
        }
        else if (!Check_Human)
        {
            before2GimmickUI();
        }
    }

    public void after2GimmickUI()
    {

        GetComponent<Renderer>().material.mainTexture = texture2;
        GetComponent<Renderer>().material.color = Color.white;
        

        //Debug.Log("シグナルUI出てるよ");
    }

    public void before2GimmickUI()
    {

        GetComponent<Renderer>().material.mainTexture = texture;
        GetComponent<Renderer>().material.color = Color.white;

        //Debug.Log("シグナルUI出てないよ");
    }
}
