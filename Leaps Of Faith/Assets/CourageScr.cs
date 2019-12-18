using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CourageScr : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
AudioSource audioData;



=======
>>>>>>> 04b093c4d266493de7cded582599d841fef4c1f0
=======



>>>>>>> parent of 04b093c... Courage Update
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
<<<<<<< HEAD
<<<<<<< HEAD

            audioData = GetComponent<AudioSource>();
            audioData.Play(1);



=======
>>>>>>> 04b093c4d266493de7cded582599d841fef4c1f0
=======





>>>>>>> parent of 04b093c... Courage Update
        }
    }


}