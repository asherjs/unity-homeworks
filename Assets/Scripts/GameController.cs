using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform sceneObject;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sceneObject.Rotate(new Vector3(speed * Time.deltaTime, 0f, speed * Time.deltaTime));
    }
}
