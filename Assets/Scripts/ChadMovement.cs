using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ChadMovement : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    [SerializeField] private LayerMask enemyMask;
    public Animator anim;
    private Transform playerTransform;

    float playerWidth;
    public float speed;

    int direction = -1;
    int counter = 0;
    public void Start(){
        playerRigidbody = this.GetComponent<Rigidbody2D>();
        playerTransform = this.transform;
        playerWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
        anim = gameObject.GetComponent<Animator>();
    }

    void FixedUpdate(){
        if(counter != 500){
            counter++;
        }
        else{
            counter = 0;
            direction *= -1;
        }
        
        Vector2 playerVelocity = playerRigidbody.velocity;
        playerVelocity.x = direction*speed;
        playerRigidbody.velocity = playerVelocity;
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag.Equals("Arrow")){
            Destroy (col.gameObject);
            Destroy (gameObject);
        }
        if(col.gameObject.name.Equals("daf")){
            playerRigidbody.position = new Vector2(transform.position.x + 2, transform.position.y);
        }
    }

    
}

