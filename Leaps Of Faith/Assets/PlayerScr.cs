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

    public Transform screenRed;

    public float RotateSpeed = 8;

    private int Jump = 1;

    AudioSource audioData;

    //public Vector3 jump;
    //public float jumpForce = 2.0f;
    //public bool isGrounded;
    //Rigidbody rb;


    int health = 1;


    /* -----------------------------------
  *-----------------------------------*/
    void Start()
    /* -----------------------------------
 *-----------------------------------*/
    {
        Cursor.visible = false;

        transform.LookAt(screenRed);

        rageInt = 1;
        rageBool = false;
    }

    /* -----------------------------------
 *-----------------------------------*/
    void Update()
    /* -----------------------------------
 *-----------------------------------*/
    
    {
        //jumping script
        if (Input.GetKeyDown("space"))
        {
            if (Jump == 1)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 350, ForceMode.Impulse);
                Debug.Log("can jump");
            }
        }



        float moveDirV = Input.GetAxis("Vertical");
        float moveDirH = Input.GetAxis("Horizontal");

        float turnDirH = Input.GetAxis("Mouse X");
        float turnDirV = Input.GetAxis("Mouse Y");

        float jumpAct = Input.GetAxis("Jump");

        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * RotateSpeed, 0);


        transform.Translate(moveSpeed * moveDirH * Time.deltaTime, 0, moveSpeed * Time.deltaTime * moveDirV);
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

        Debug.Log(health);



       if (Input.GetKey("q"))
        {
            moveSpeed = 20;
          
        }
        else
        {
            moveSpeed = 8;
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }

   
    
       


        Debug.Log(rageBool + "   " + moveSpeed);







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

        if (col.gameObject.name == "Edge")
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single); ;
        }


    }
}

