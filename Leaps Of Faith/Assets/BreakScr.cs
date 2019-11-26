using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakScr : MonoBehaviour
{
    int health;
    public int chooseHealth;

    void Start()
    {
        health = chooseHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health + "box");

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