using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public GameObject door_open;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        door_open = GameObject.Find("door_open");
    }

    // Update is called once per frame
    void Update()
    {
        if(Keys_UI.keysCollected == 3 && Daf_Movement.openDoor == true){
            anim.SetTrigger("Active");
            door_open.SetActive(true);
        }
    }
}
