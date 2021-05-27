using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planting : MonoBehaviour
{
    // 種発射点
    private GameObject seed;

    // 種発射点
    private Transform plantTop;

    // 種の速度
    private float speed = 250;

    // Update is called once per frame
    public void Plant(float x,float y,GameObject seed, Transform plantTop)
    {
        if (x == 0)
        {
            x = 0.2f;
        }

        // 種の複製
        GameObject seeds = Instantiate(seed);

        Vector2 force;

        force = new Vector2(x, y*1.5f) * speed;

        // Rigidbodyに力を加えて発射
        seeds.GetComponent<Rigidbody2D>().AddForce(force);

        // 種の位置を調整
        seeds.transform.position = new Vector2(plantTop.position.x+1.0f, plantTop.position.y + 3.5f);

    }
}
