using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating_sign : MonoBehaviour
{
    private Rigidbody2D signRigidbody;

    private int counter = 0;

    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        signRigidbody = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(counter != 30){
            counter++;
        }
        else{
            direction *= -1;
            signRigidbody.velocity = new Vector2(0,direction*0.5f); 
            counter = 0;
        }

    }
}
