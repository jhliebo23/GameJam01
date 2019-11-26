using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFPScript : MonoBehaviour
{
    public int sens;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float turnDirH = Input.GetAxis("Mouse X");
        float turnDirV = Input.GetAxis("Mouse Y");

        transform.Rotate(0, turnDirH * sens * Time.deltaTime, 0);
        transform.Rotate(turnDirV * -1 * sens * Time.deltaTime, 0, 0);
    }
}
