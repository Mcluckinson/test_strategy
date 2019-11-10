using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    public int _speed = 1;

    private void OnMouseDown()
    {
        _speed = 9999;
        Time.timeScale = 100;
    }
}
