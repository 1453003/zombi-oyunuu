using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
   
    float _mouseX = 0.0f;
    float _sensitivity = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _mouseX = Input.GetAxis("Mouse X");

        Vector3 rot = transform.localEulerAngles;
        rot.y += _mouseX*_sensitivity;
        transform.localEulerAngles = rot;
    }
}
