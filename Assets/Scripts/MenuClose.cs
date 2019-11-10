using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuClose : MonoBehaviour
{
    public GameObject targetCanvas;

    private void OnMouseDown()
    {
        targetCanvas.SetActive(false);
    }
}
