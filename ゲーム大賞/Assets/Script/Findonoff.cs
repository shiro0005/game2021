using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Findonoff : MonoBehaviour
{
    //リストで親から子を見つけて取得
    public List<GameObject> familyList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Transform parentTransform = GameObject.Find("Target").transform;//親obj

        foreach (Transform child in parentTransform)
        {
            familyList.Add(child.gameObject);
            print(child.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
