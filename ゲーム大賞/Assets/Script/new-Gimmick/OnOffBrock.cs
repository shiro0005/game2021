using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffBrock : MonoBehaviour
{
    [SerializeField] bool FirstBrockFlag;

    public bool GetFlag()
    {
        return FirstBrockFlag;
    }
}
