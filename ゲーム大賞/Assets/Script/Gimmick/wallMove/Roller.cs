using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{

    public float Agi;
    float spe;

    public float Ti;
    public float Su;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, Ti, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (lie == true)
        //{
        //    ActionPosition();
        //}

        //if (lie == false)
        //{
        //    SilentPosition();
        //}
    }

    public void ActionPosition()
    {
        //Vector3 position = this.transform.localPosition;
        //Quaternion rotation = this.transform.localRotation;
        //Vector3 scale = this.transform.localScale;

        //// クォータニオン → オイラー角への変換
        //Vector3 rotationAngles = rotation.eulerAngles;

        //// X軸の90度回転
        ////rotationAngles.y = rotationAngles.y + 90.0f;
        //// Vector3の加算は以下のような書き方も可能
        //rotationAngles += new Vector3(0.0f, 180.0f, 0.0f);

        //// オイラー角 → クォータニオンへの変換
        //rotation = Quaternion.Euler(rotationAngles);

        //// Transform値を設定する
        //this.transform.localPosition = position;
        //this.transform.localRotation = rotation;
        //this.transform.localScale = scale;

        transform.rotation = Quaternion.Euler(0, Su, 0);

    }

    public void SilentPosition()
    {
        //Vector3 position = this.transform.localPosition;
        //Quaternion rotation = this.transform.localRotation;
        //Vector3 scale = this.transform.localScale;

        //// クォータニオン → オイラー角への変換
        //Vector3 rotationAngles = rotation.eulerAngles;

        //// X軸の90度回転
        ////rotationAngles.y = rotationAngles.y - 90.0f;
        //// Vector3の加算は以下のような書き方も可能
        //rotationAngles += new Vector3(0.0f, 90.0f, 0.0f);

        //// オイラー角 → クォータニオンへの変換
        //rotation = Quaternion.Euler(rotationAngles);

        //// Transform値を設定する
        //this.transform.localPosition = position;
        //this.transform.localRotation = rotation;
        //this.transform.localScale = scale;

        transform.rotation = Quaternion.Euler(0, Ti, 0);

    }
}
