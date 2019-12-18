using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class CourageScr : MonoBehaviour
{
<<<<<<< HEAD
AudioSource audioData;



=======
>>>>>>> 04b093c4d266493de7cded582599d841fef4c1f0
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
<<<<<<< HEAD

            audioData = GetComponent<AudioSource>();
            audioData.Play(1);



=======
>>>>>>> 04b093c4d266493de7cded582599d841fef4c1f0
        }
    }
}