using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ChadMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;


    public void Awake(){
        playerRigidbody = GetComponent<Rigidbody2D>();

    }
    
    private bool isGrounded(){
        float extraHeightText = 0.01f;
        RaycastHit2D hit = Physics2D.Raycast(GetComponent<BoxCollider2D>().bounds.center, Vector2.down, GetComponent<BoxCollider2D>().bounds.extents.y + extraHeightText);
        Color rayColor;
        if(hit.collider != null){
            rayColor = Color.green;
        }
        else{
            rayColor = Color.red;
        }
        Debug.DrawRay(GetComponent<BoxCollider2D>().bounds.center, Vector2.down * (GetComponent<BoxCollider2D>().bounds.extents.y + extraHeightText));
        return hit.collider != null;
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
        Vector2 velocity = new Vector2(-5,0);

        if(isGrounded()){
            playerRigidbody.velocity = velocity;
        }
        else{
            playerRigidbody.velocity = new Vector2(0,0);
        }

        // Debug.Log("Velocity: " + playerRigidbody.velocity.x + playerRigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag.Equals("Arrow")){
            Destroy (col.gameObject);
            Destroy (gameObject);
        }
    }
}
