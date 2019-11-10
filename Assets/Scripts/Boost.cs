using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public bool _boost = false;
    public int speed = 1;
    public int month = 2592000;

    private void OnMouseDown()
    {
        Debug.Log("Ok");
        if (_boost == false)
        {
            speed = 9999;
            Time.timeScale = 100;
            month /= 5000;
            _boost = true;
        }
        else
        {
            speed = 1;
            Time.timeScale = 1;
            month = 2592000;
            _boost = false;
        }
    }
}
