using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    public GameObject targetCanvas;

    public GameObject site;

    [SerializeField] private List<GameObject> menu;
    [SerializeField] private List<GameObject> buildings;

    void OnMouseDown()
    {
        for (int i = 0; i < buildings.Count; i++)
        {
            if (menu[i].name == name)
                Instantiate(buildings[i], site.transform.position, buildings[i].transform.rotation);
        }
        targetCanvas.SetActive(false);
    }
}
