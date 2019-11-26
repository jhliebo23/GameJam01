using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScr : MonoBehaviour
{
    private bool canJump;
    public int moveSpeed = 8;
    public int jumpHeight;

    public GameObject dagger;
    public GameObject bullet;

    public int sens;

    int health = 3;


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
        float turnDirV = Input.GetAxis("Mouse Y");

        float jumpAct = Input.GetAxis("Jump");

       

        transform.Translate(10 * moveDirH * Time.deltaTime, 0, 10 * Time.deltaTime * moveDirV);
        transform.Rotate(0, turnDirH * sens * Time.deltaTime, 0);
        transform.Rotate(turnDirV * -1 * sens * Time.deltaTime, 0,0);



        Debug.Log(canJump);

        if (canJump && (jumpAct == 1)) 
        { 
            transform.position += (Vector3.up * jumpHeight * Time.deltaTime);

           
        }

        if (health < 0)

        {

            transform.position = new Vector3(-239, 84, -152);

        

            health = 50;
        }

        Debug.Log(health);

    }

    void OnTriggerEnter(Collider col)
    {


        if (col.gameObject.tag == "bullet")
        {
            health--;

        }


        if (col.gameObject.name == "Floor")
        {
            canJump = true;

            Debug.Log("touching");

         
        }
        else
        {
            canJump = false;
            Debug.Log("can't jump");
        }





    }
}
