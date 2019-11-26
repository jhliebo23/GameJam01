using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTele : MonoBehaviour
{

    public Transform itself;
    public Transform getter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        { 
        itself.transform.position = getter.transform.position;
            Debug.Log("Sig hit");
         }
    }


}
