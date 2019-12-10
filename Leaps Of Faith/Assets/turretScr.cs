﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretScr : MonoBehaviour
{
    public GameObject prefab;

  
   private float time = 0.0f;
    public float interpolationPeriod = 2f;
    public float xCord;
    public float yCord;
    public float zCord;
    public float timeMax;
  
    void Start()
    {
        time = 2;
    }

    // Update is called once per frame
    void Update()
    {
       

         time += Time.deltaTime;


         if (time > timeMax)

         {
             Instantiate(prefab, new Vector3(xCord, yCord, zCord), Quaternion.identity);

         }

         if (time >= interpolationPeriod)
         {
             time = 0.0f;


         }


        

   
    }


}
