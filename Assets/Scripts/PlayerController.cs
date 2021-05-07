using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speedRotation = 60f;
    private float _speedTranslation = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, 0f, -_speedRotation * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0f, 0f, _speedRotation * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(_speedTranslation * Time.deltaTime * Vector3.up);
        }
        else  if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(_speedTranslation * Time.deltaTime * Vector3.down);
        }
    }
}