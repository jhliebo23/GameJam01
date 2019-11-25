using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakScr : MonoBehaviour
{
    int health;

    void Start()
    {
        health = 30;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health);

        if (health < 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {


        if (col.gameObject.tag == "dagger")
        {
            health--;

        }





    }
}