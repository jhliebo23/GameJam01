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
        float jumpAct = Input.GetAxis("jump");


        transform.Translate(10 * moveDirH * Time.deltaTime, 0, 10 * Time.deltaTime * moveDirV);
        transform.Rotate(0, turnDirH * 700 * Time.deltaTime, 0);


        if (canJump && (jumpAct > 0)) 
        { 
            transform.position += (Vector3.up * jumpHeight * Time.deltaTime);

            Debug.Log("canJump and keydown");
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


        if (col.gameObject.tag == "ground")
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }





    }
}
