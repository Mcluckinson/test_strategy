using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingHouse : MonoBehaviour
{
    public Animator animator;
    public int month;
    private float tim;
    private GameObject boost;

    private void Start()
    {
        boost = GameObject.Find("Boost");
        tim = Time.fixedTime;
    }

    void Update()
    {
        if (month * boost.GetComponent<Boost>().month / 4 < Time.fixedTime - tim)
            animator.SetBool("house1", true);
        if (month * boost.GetComponent<Boost>().month / 3 < Time.fixedTime - tim)
            animator.SetBool("house2", true);
        if (month * boost.GetComponent<Boost>().month / 2 < Time.fixedTime - tim)
            animator.SetBool("house3", true);
        if (month * boost.GetComponent<Boost>().month < Time.fixedTime - tim)
            animator.SetBool("house4", true);
    }
}
