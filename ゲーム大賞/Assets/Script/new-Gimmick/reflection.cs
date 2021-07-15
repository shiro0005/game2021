using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reflection : MonoBehaviour
{
    [SerializeField] Vector2 vec;
    [SerializeField] Vector2 reflectpower;
    public Vector2 GetVector(Vector2 vector2)
    {
        if(vec== new Vector2(0.0f, 0.0f))
        {
            return vector2* reflectpower;
        }

        return vec;
    }
}
