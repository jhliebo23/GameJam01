﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingScr : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * 2);
        transform.LookAt(target);
    }
}
