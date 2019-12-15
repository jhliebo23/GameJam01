using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScr : MonoBehaviour
{
    private bool canJump;
    public int moveSpeed = 10;
    public int jumpHeight;

    public GameObject dagger;
    public GameObject bullet;

    private Rigidbody rb;

    int rageInt;

    bool rageBool;

    public GameObject lava;

    public float RotateSpeed = 8;

    //private int Jump = 1;

    //AudioSource audioData;

   public  GameObject rageUI;


    //public Vector3 jump;
    //public float jumpForce = 2.0f;
    //public bool isGrounded;
    //Rigidbody rb;


    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.forward;

    int health = 1;


    /* -----------------------------------
  *-----------------------------------*/
    void Start()
    /* -----------------------------------
 *-----------------------------------*/
    {
        Cursor.visible = false;


        rageInt = 1;
        rageBool = false;

        characterController = GetComponent<CharacterController>();

        //rb = GetComponent<Rigidbody>();
    }

    /* -----------------------------------
 *-----------------------------------*/
    void Update()
    /* -----------------------------------
 *-----------------------------------*/
    
    {
        Vector3 moveValues = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        characterController.Move(moveValues);

        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

        
            //transform.Translate(Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            

            //float moveDirV = Input.GetAxis("Vertical");
            //float moveDirH = Input.GetAxis("Horizontal");
            //transform.Translate(moveSpeed * moveDirH * Time.deltaTime, 0, moveSpeed * Time.deltaTime * moveDirV);

        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
        //jumping script
        //if (Input.GetKeyDown("space"))
        //{
        //        GetComponent<Rigidbody>().AddForce(Vector3.up * 350, ForceMode.Impulse);
        //        Debug.Log("can jump");
        //}



        //float moveDirV = Input.GetAxis("Vertical");
        //float moveDirH = Input.GetAxis("Horizontal");

        //float turnDirH = Input.GetAxis("Mouse X");
        //float turnDirV = Input.GetAxis("Mouse Y");

        //float jumpAct = Input.GetAxis("Jump");

        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * RotateSpeed, 0);


        //transform.Translate(moveSpeed * moveDirH * Time.deltaTime, 0, moveSpeed * Time.deltaTime * moveDirV);



     /*   transform.Rotate(0, turnDirH * sens * Time.deltaTime, 0);
        transform.Rotate(turnDirV * -1 * sens * Time.deltaTime, 0,0); */

        //Debug.Log(canJump);

        //if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        //{
        //    rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        //    isGrounded = false;
        //    Debug.Log("CanJump");


        //transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Jump"), Space.World);

        //if (canJump && (jumpAct == 1)) 
        //{ 
        //    transform.position += (Vector3.up * jumpHeight * Time.deltaTime);
        //    Debug.Log("CanJump");
           
        //}

        if (health < 0)

        {

            transform.position = new Vector3(-239, 84, -152);

        

            health = 50;
        }

        //Debug.Log(health);



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

 
     /* -----------------------------------
      *-----------------------------------*/   
       void OnTriggerEnter(Collider col)
    /* -----------------------------------
   *-----------------------------------*/

    {

        if (col.gameObject.tag == "bullet")
        {
            health--;

        }


        //if (col.gameObject.name == "Floor")
        //{
        //    canJump = true;

        //    Debug.Log("touching");


        //}
        else
        {
            canJump = false;
            Debug.Log("can't jump");
        }

        if (col.gameObject.name == "Edge")
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single); ;
        }


    }

    //private void FixedUpdate()
    //{
    //    if (Input.GetKeyDown("w"))
    //    {
    //        rb.AddForce(Vector3.forward * 100, ForceMode.VelocityChange);
    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Finish")
        {
            Debug.Log("Heyo");
        }
    }

}


