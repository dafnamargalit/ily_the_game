﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_platform : MonoBehaviour
{
    private Rigidbody2D platformRigidbody;

    private int counter = 0;

    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        platformRigidbody = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(counter != 90){
            counter++;
        }
        else{
            direction *= -1;
            counter = 0;
        }
         
        platformRigidbody.velocity = new Vector2(0,direction*4f); 

    }
}
