using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingHouse : MonoBehaviour
{
    public GameObject boost;
    public Animator animator;
    public int month;
    private float tim;

    private void Start()
    {
        tim = Time.fixedTime;
    }

    void Update()
    {
        //month += boost.GetComponent<Boost>().month;
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
