using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerThrow : MonoBehaviour
{
    public Transform teleportTarget;
    public Transform dagger;

    private float time = 0.0f;
    public float interpolationPeriod = 1f;

    bool ready = false;
    public int throwTIme = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        transform.Translate(0, 0, 1);

        if (throwTIme > 0.5)

        {


            if (Input.GetMouseButtonDown(0))
            {

                dagger.transform.position = teleportTarget.transform.position;
               
                throwTIme = 0;

            }
        }

        if (time >= interpolationPeriod)
        {
            time = 0.0f;

            throwTIme++;

           }
       


    }





   }




