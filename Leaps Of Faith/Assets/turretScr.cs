using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretScr : MonoBehaviour
{
    public GameObject prefab;

    int fireTime;
    private float time = 0.0f;
    public float interpolationPeriod = 1f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;


        if (fireTime > 0.5)

        {
            Instantiate(prefab, new Vector3(-3, 40, 7.5f), Quaternion.identity);

        }

        if (time >= interpolationPeriod)
        {
            time = 0.0f;


        }


       
        
    }
}
