using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretScr : MonoBehaviour
{
    public GameObject prefab;

  
   private float time = 0.0f;
    public float interpolationPeriod = 2f;
    public int xCord;
    public int yCord;
    public int zCord;
  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

         time += Time.deltaTime;


         if (time > 4f)

         {
             Instantiate(prefab, new Vector3(xCord, yCord, zCord), Quaternion.identity);

         }

         if (time >= interpolationPeriod)
         {
             time = 0.0f;


         }


        

   
    }


}
