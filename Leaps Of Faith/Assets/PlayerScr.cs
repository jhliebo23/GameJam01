using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScr : MonoBehaviour
{
    private bool canJump;
    public int moveSpeed = 8;
    public int jumpHeight;

    public GameObject dagger;
    public GameObject bullet;

    public int sens;

    //public Vector3 jump;
    //public float jumpForce = 2.0f;
    //public bool isGrounded;
    //Rigidbody rb;


    int health = 1;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        //rb = GetComponent<Rigidbody>();
        //jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    isGrounded = true;
    //}

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

        if (col.gameObject.name == "Edge")
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single); ;
        }



    }
}
