using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject tttt;
    public TextMesh textmesh;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        time = time * 30 * 60 * 60 * 24;
        textmesh.text = (time / (30 * 60 * 60 * 24)).ToString() + " month " + ((time / (60 * 60 * 24)) % 30).ToString() + " day " + ((time / (60 * 60)) % (24)).ToString() + " hour " + ((time / (60)) % 60).ToString() + " minute " + (time % 60).ToString() + " seconds";
    }

    private void FixedUpdate()
    { 
        time -= tttt.GetComponent<speed>()._speed;
        textmesh.text = (time / (30 * 60 * 60 * 24)).ToString() + " month " + ((time / (60 * 60 * 24)) % 30).ToString() + " day\n" + ((time / (60 * 60)) % (24)).ToString() + " hour " + ((time / (60)) % 60).ToString() + " minute\n" + (time % 60).ToString() + " seconds";
        if (time < 0)
            textmesh.transform.GetComponent<MeshRenderer>().enabled = false;
    }
}
