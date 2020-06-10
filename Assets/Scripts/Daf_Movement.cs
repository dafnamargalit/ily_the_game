using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daf_Movement : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    public Animator anim;
    private Rigidbody2D playerRigidbody;
    public GameObject arrow;
    Vector2 arrowPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    public int score = 0;
    float moveDirection = 1;

    public static float arrowDirection = 1;
    int timesHit = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void Awake(){
        playerRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
        {
            // int count = Input.touchCount;
            if(playerRigidbody != null){
                if(Input.GetKey(KeyCode.RightArrow)){
                    moveDirection = 1;
                    move();
                }
                if(!Input.GetKey(KeyCode.RightArrow)){
                    anim.SetBool("isRunning", false);
                    playerRigidbody.velocity = new Vector2(0, playerRigidbody.velocity.y);
                }
                if(Input.GetKey(KeyCode.LeftArrow)){
                    moveDirection = -1;
                    move();
                }
                if(Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire){
                    fire();
                }
                if(Input.GetKeyUp(KeyCode.Space)){
                    anim.SetBool("isShooting", false);
                }
                if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded()){
                    jump();
                }
                if(Input.GetKeyUp(KeyCode.UpArrow)){
                    anim.SetBool("isJumping", false);
                }
            }
            else{
                Debug.Log("GAME OVER");
            }
    }


    void fire()
    {
        Vector3 currRot = this.transform.eulerAngles;
    
        if(moveDirection > 0){
            arrowDirection = 1;
            currRot.y = 0;
            this.transform.eulerAngles = currRot;
        }
        else{
            arrowDirection = -1;
            currRot.y = 180;
            this.transform.eulerAngles = currRot;
        }
        arrowPos = transform.position;
        arrowPos += new Vector2(1f,0.1f);
        Instantiate(arrow, arrowPos, Quaternion.identity);
        if(isGrounded()){
        anim.SetBool("isShooting", true);
         }
    }

    void move()
    {
        playerRigidbody.isKinematic = false;
        transform.parent = null;
        Vector3 currRot = this.transform.eulerAngles;
        if(moveDirection > 0){
            currRot.y = 0;
            this.transform.eulerAngles = currRot;
        }
        else{
            currRot.y = 180;
            this.transform.eulerAngles = currRot;
        }
        playerRigidbody.velocity = new Vector2(10f*moveDirection,playerRigidbody.velocity.y);
        if(isGrounded()){
            anim.SetBool("isRunning", true);
        }
        else{
            anim.SetBool("isRunning", false);
        }
    }
    
    void jump(){
        playerRigidbody.isKinematic = false;
        transform.parent = null;
        playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x,11);
        anim.SetBool("isJumping", true);
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
        return hit.collider != null;
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag.Equals("Enemy") && timesHit == 2){
            Destroy (gameObject);
        }
        else if(col.gameObject.tag.Equals("Enemy")){
            Debug.Log("hit");
            timesHit++;
            Debug.Log(timesHit);
        }
        if(col.gameObject.tag.Equals("Flames")){
            Destroy(gameObject);
        }
        if(col.gameObject.tag.Equals("Spikes")){
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D col){
        if(col.gameObject.tag.Equals("moving_platty")){
            Debug.Log("on platform");
            playerRigidbody.isKinematic = true;
            transform.parent = col.transform;
        }
    }

}



