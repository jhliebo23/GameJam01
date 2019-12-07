using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourageScr : MonoBehaviour
{
    private Vector3 Min;
    private Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private float _zAxis; //If you need this, use it
    private Vector3 _randomPosition;
    public bool _canInstantiate;

    private float time = 0.0f;
   
    public float timeMax;

    int copies;

    private void Start()
    {
        SetRanges();
        time = 222;
        timeMax = 222;
    }
    private void Update()
    {

        Debug.Log(time);

        time += Time.deltaTime;


        if ((time >= timeMax) && (copies <= 2))

        {
            Instantiate(gameObject, _randomPosition, Quaternion.identity);
            Debug.Log("InstatCour");

            time = 0.0f;

            copies++;
        }

     





        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
        _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);

      
    }
    //Here put the ranges where your object will appear, or put it in the inspector.
    private void SetRanges()
    {
        Min = new Vector3(-46, 2, 46); //Random value.
        Max = new Vector3(40, 12, -39); //Another ramdon value, just for the example.
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            copies--;

        }
    }


}


