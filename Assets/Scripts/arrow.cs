using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update

    public float velX;
    float velY = 0;
    float direction = 1;     
    Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 currRot = this.transform.eulerAngles;
        direction = Daf_Movement.arrowDirection;
        if(direction > 0 && rb.velocity != new Vector2(-direction*velX,velY)){
            currRot.y = 0;
            this.transform.eulerAngles = currRot;
        }
        else if(rb.velocity != new Vector2(-direction*velX,velY)){
            currRot.y = 180;
            this.transform.eulerAngles = currRot;
        }
        if(rb.velocity != new Vector2(-direction*velX,velY)){
            rb.velocity = new Vector2(direction*velX, velY);
        }
        Destroy (rb.gameObject, 1f);
    }

    private void OnCollisionEnter2D(){
      Destroy(rb.gameObject);
    }
}
