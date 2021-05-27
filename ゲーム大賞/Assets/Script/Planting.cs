using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planting : MonoBehaviour
{
    // 種発射点
    public GameObject seed;

    // 種発射点
    public Transform plantTop;


    // 種の速度
    public float speed = 250;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // z キーが押された時
        if (Input.GetKeyDown(KeyCode.Space))
        {

            // 種の複製
            GameObject seeds = Instantiate(seed) as GameObject;

            Vector3 force;

            force = new Vector3(0.8f, 1.0f, 0.0f)*speed;

            // Rigidbodyに力を加えて発射
            seeds.GetComponent<Rigidbody>().AddForce(force);

            // 種の位置を調整
            seeds.transform.position = new Vector3(plantTop.position.x, plantTop.position.y + 1.0f, plantTop.position.z);
        }
    }
}
