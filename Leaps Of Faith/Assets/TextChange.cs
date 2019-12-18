using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public TextMesh courage = null;

    // Start is called before the first frame update
    void Start()
    {
        courage.text = "Courage: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
