using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    void Start()
    {
        GameObject[] lights = GameObject.FindGameObjectsWithTag("StreetLight");
        foreach (GameObject light in lights)
        {
            light.GetComponent<Light>().enabled = true;
        }
            
    }

    void Update()
    {
        
    }
}
