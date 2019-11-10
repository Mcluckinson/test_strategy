using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingHouse : MonoBehaviour
{
    public Animator animator;
    public int month;
    private float tim;

    private void Start()
    {
        tim = Time.fixedTime;
    }

    void Update()
    {
        if (month / 4 < Time.fixedTime - tim)
            animator.SetBool("house1", true);
        if (month * 30 * 24 * 60 * 60 / 3 < Time.fixedTime - tim)
            animator.SetBool("house2", true);
        if (month * 30 * 24 * 60 * 60 / 2 < Time.fixedTime - tim)
            animator.SetBool("house3", true);
        if (month * 30 * 24 * 60 * 60 < Time.fixedTime - tim)
            animator.SetBool("house4", true);
    }
}
