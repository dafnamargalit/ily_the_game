using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EboyMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    int hitCount = 0;
    public void Awake(){
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    private void FixedUpdate()
    {
        if(playerRigidbody != null){
            ApplyInput();
        }
        else{
            Debug.LogWarning("Rigid body not attached to player" + gameObject.name);
        }
    }

    // public bool isGrounded(Collision theCollision){
    //    if(theCollision.gameObject.name == "ground"){
    //        return true;
    //    }
    //    return false;
    // }

    public void ApplyInput(){
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        // float xForce = xInput * moveSpeed * Time.deltaTime;
      
        Vector2 velocity = new Vector2(-7f,0);

        playerRigidbody.velocity = velocity;

        // Debug.Log("Velocity: " + playerRigidbody.velocity.x + playerRigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag.Equals("Arrow")){
            hitCount++;
            Destroy (col.gameObject);
            if(hitCount == 2){
                Destroy (gameObject);
            }
        }
    }
}
