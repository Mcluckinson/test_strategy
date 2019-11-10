using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpen : MonoBehaviour
{
    public GameObject targetCanvas;

    private Color basicColor;
    private Color hoverColor = new Color(0.1f, 0.1f, 0.1f, 1.0f);
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        basicColor = _renderer.material.color;
    }

    void OnMouseEnter()
    {
        _renderer.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        _renderer.material.color = basicColor;
    }

    private void OnMouseDown()
    {
        targetCanvas.GetComponent<MenuSiteRemember>().site = gameObject;
        targetCanvas.SetActive(true);
    }
}
