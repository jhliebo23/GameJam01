using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScr : MonoBehaviour
{
    public GameObject dagger;
    public GameObject bullet;

    int rageInt;

    bool rageBool;

    float courageVal = 0f;

    int health = 1;

    //AudioSource audioData;

    public  GameObject rageUI;

    public CharacterController controller;

    public float speed = 10f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

    void Start()
    {
        Cursor.visible = false;

        rageInt = 1;
        rageBool = false;
    }


    void Update()
    {
        //start of movement script ---------------------------------------------------------
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -7f;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        //end of movement script -----------------------------------------------------------

        if (health < 0)
        {
            transform.position = new Vector3(-239, 84, -152);

            health = 50;
        }

       if (Input.GetKey("q") && courageVal == 1)
        {
            speed = 20f;
            rageUI.SetActive(true);
            jumpHeight = 5f;
        }
        else
        {
            speed = 10f;
            jumpHeight = 3f;
            rageUI.SetActive(false);
        }

        //Debug.Log(rageBool + "   " + moveSpeed);

    }   
       void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bullet")
        {
            health--;
        }

        if (col.gameObject.tag == "courage")
        {
            courageVal++;
        }
    }

}


