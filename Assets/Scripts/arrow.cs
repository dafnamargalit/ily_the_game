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
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velX, velY);
        Destroy (rb.gameObject, 3f);
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name.Equals("chad") ||col.gameObject.name.Equals("eboy") || col.gameObject.name.Equals("Arrow")){
            Destroy (col.gameObject);
        }
    }
}
