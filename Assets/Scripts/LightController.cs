using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject[] lights;

    [HideInInspector]
    public float time;

    [HideInInspector]
    public DayNightController dayNightController;
    [HideInInspector]
    public GameObject sun;

    void Start()
    {
        sun = GameObject.FindGameObjectWithTag("SunLight");
        dayNightController = sun.GetComponent<DayNightController>();
       
        lights = GameObject.FindGameObjectsWithTag("StreetLight");

    }

    void Update()
    {
        time = dayNightController.time;
        Debug.Log(time);

        foreach (GameObject light in lights)
        {
            light.GetComponent<Light>().enabled = true;
        }

        if (time > 6 && time < 18)
        {
            foreach (GameObject light in lights)
            {
                light.GetComponent<Light>().enabled = false;
            }
        }
        else
        {
            foreach (GameObject light in lights)
            {
                light.GetComponent<Light>().enabled = true;
            }
        }
    }
}
