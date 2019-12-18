using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourageScr : MonoBehaviour
{



    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);





        }
    }


}