using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public Text text;
    int c = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Collisions: 0";
        text.fontSize = 20;
        text.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        c++;
        text.text = "Collisions: " + c.ToString();
    }
}
