using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EboyMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;

    int timesHit = 0;
    [SerializeField] private LayerMask platformLayerMask;

    public void Awake(){
        playerRigidbody = GetComponent<Rigidbody2D>();

    }
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        if(playerRigidbody != null){
            if(isGrounded()){
                ApplyInput();
            }
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

        playerRigidbody.velocity = velocity;

        // Debug.Log("Velocity: " + playerRigidbody.velocity.x + playerRigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag.Equals("Arrow")){
            Destroy (col.gameObject);
            timesHit++;

            if(timesHit == 2){
                Destroy (gameObject);
            }
        }
        if(col.gameObject.name.Equals("daf")){
            playerRigidbody.position = new Vector2(transform.position.x + 2, transform.position.y);
        }
    }

    private bool isGrounded(){
        float extraHeightText = 0.1f;
        RaycastHit2D hit = Physics2D.Raycast(GetComponent<BoxCollider2D>().bounds.center, Vector2.down, GetComponent<BoxCollider2D>().bounds.extents.y + extraHeightText, platformLayerMask);
        Color rayColor;
        if(hit.collider != null){
            rayColor = Color.green;
        }
        else{
            rayColor = Color.red;
        }
        Debug.DrawRay(GetComponent<BoxCollider2D>().bounds.center, Vector2.down * (GetComponent<BoxCollider2D>().bounds.extents.y + extraHeightText));
        Debug.Log(hit.collider);
        return hit.collider != null;
    }
}

