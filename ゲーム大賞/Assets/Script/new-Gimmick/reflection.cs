using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reflection : MonoBehaviour
{
    [SerializeField] Vector2 vec;

    public Vector2 GetVector()
    {
        return vec;
    }
}
