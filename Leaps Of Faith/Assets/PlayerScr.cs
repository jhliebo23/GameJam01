using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScr : MonoBehaviour
{
    public GameObject dagger;
    public GameObject bullet;

    public float moveSpeed = 10f;

    int rageInt;

    bool rageBool;

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

        if (health < 0)
        {
            transform.position = new Vector3(-239, 84, -152);

            health = 50;
        }

       if (Input.GetKey("q"))
        {
            moveSpeed = 40;
            rageUI.SetActive(true);
        }
        else
        {
            moveSpeed = 75;
            //audioData = GetComponent<AudioSource>();
            //audioData.Play(0);
            //rageUI.SetActive(false);
        }

        //Debug.Log(rageBool + "   " + moveSpeed);

    }   
       void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bullet")
        {
            health--;
        }

        if (col.gameObject.name == "Edge")
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single); ;
        }
    }

}


