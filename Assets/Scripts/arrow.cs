using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update

    public float velX;
    float velY = 0;

    Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 currRot = this.transform.eulerAngles;
        if(Daf_Movement.arrowDirection > 0){
            currRot.y = 0;
            this.transform.eulerAngles = currRot;
        }
        else{
            currRot.y = 180;
            this.transform.eulerAngles = currRot;
        }

        rb.velocity = new Vector2(Daf_Movement.arrowDirection*velX, velY);
        Destroy (rb.gameObject, 1f);
    }

    private void OnCollisionEnter2D(){
      Destroy(rb.gameObject);
    }
}
