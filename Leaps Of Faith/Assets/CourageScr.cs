using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CourageScr : MonoBehaviour
{
AudioSource audioData;



    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            audioData = GetComponent<AudioSource>();
            audioData.Play(1);



        }
    }


}