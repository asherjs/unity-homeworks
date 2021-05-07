using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject sun;
    public Light sunLight;

    [Range(0, 24)]
    public float time = 12;

    public float secondsPerMinute = 1;
    [HideInInspector]
    public float secondsPerHour;
    [HideInInspector]
    public float secondsPerDay;

    public float timeMultiplier = 1;
    void Start()
    {
        sun = gameObject;
        sunLight = gameObject.GetComponent<Light>();

        secondsPerHour = secondsPerMinute * 60;
        secondsPerDay = secondsPerHour * 24;

        // GameObject[] lights = GameObject.FindGameObjectsWithTag("StreetLight");
        // foreach (GameObject light in lights)
        //{
        //light.GetComponent<Light>().enabled = true;
        //}

    }

    void Update()
    {
        SunUpdate();

        time += (Time.deltaTime / secondsPerDay) * timeMultiplier;

        if (time >= 24)
        {
            time = 0;
        }
    }

    public void SunUpdate()
    {
        sun.transform.localRotation = Quaternion.Euler(((time / 24) * 360f) - 90, 90, 0);
    }
}
