using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScr : MonoBehaviour
{

    public GameObject cube;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirV = Input.GetAxis("Vertical");
        float moveDirH = Input.GetAxis("Horizontal");

        float turnDirH = Input.GetAxis("Mouse X");


        transform.Translate( 10 * moveDirH * Time.deltaTime, 0, 10 * Time.deltaTime * moveDirV);
        transform.Translate(10 * turnDirH * Time.deltaTime,0,0);

       if (Input.GetKeyDown("space"))
        {

            transform.Translate(0,2,0);

        }

         void OnCollisionEnter(Collision collision)
        {

        }

        /*   if (Input.GetMouseButtonDown(0)) 
         {
             Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
         }


     */



    }
}

