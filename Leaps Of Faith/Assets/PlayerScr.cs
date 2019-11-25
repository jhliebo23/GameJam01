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


        transform.Translate(10 * moveDirH * Time.deltaTime, 0, 10 * Time.deltaTime * moveDirV);
        transform.Rotate(0, turnDirH * 700 * Time.deltaTime, 0);


        if (canJump && Input.GetKey(KeyCode.Space))
        {
            transform.position += (Vector3.up * jumpHeight * Time.deltaTime);
        }

        if (health < 0)

        {
            transform.Translate(999, 999, 999);
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





    }
}
