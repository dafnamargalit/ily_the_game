using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Key_Collector : MonoBehaviour
{
    private Rigidbody2D keyRigidbody;

    private int counter = 0;

    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        keyRigidbody = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(counter != 30){
            counter++;
        }
        else{
            direction *= -1;
            keyRigidbody.velocity = new Vector2(0,direction*0.5f); 
            counter = 0;
        }

    }

     private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name.Equals("daf")){
            Destroy (gameObject);
            ScoreText.score += 25;
            Keys_UI.keysCollected++;
        }
    }
}
