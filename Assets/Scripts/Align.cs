using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    void Start()
    {
        transform.position += new Vector3(x, y, z);
    }
}
