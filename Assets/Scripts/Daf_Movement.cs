using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daf_Movement : MonoBehaviour
{
    public Animator anim;
    public GameObject arrow;
    Vector2 arrowPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // int count = Input.touchCount;
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire){
            Debug.Log("shoot");
            nextFire = Time.time + fireRate;
            fire();
        }
    }

    void fire()
    {
        arrowPos = transform.position;
        arrowPos += new Vector2(1f,0f);
        Instantiate(arrow, arrowPos, Quaternion.identity);
        
    }
}



