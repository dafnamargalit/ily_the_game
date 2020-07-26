using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class Keys_UI : MonoBehaviour
{

    public static int keysCollected;

    private GameObject key_1;
    private GameObject key_2;
    private GameObject key_3;

    SpriteRenderer image_1;
    SpriteRenderer image_2;
    SpriteRenderer image_3;
    // Start is called before the first frame update
    void Start()
    {
        key_1 = GameObject.Find("key_1");
        if(key_1){
            image_1 = key_1.GetComponent<SpriteRenderer>();
        }       
        key_2 = GameObject.Find("key_2");
        if(key_2){
            image_2 = key_2.GetComponent<SpriteRenderer>();
        }
        key_3 = GameObject.Find("key_3");
        if(key_3){
            image_3 = key_3.GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(key_1){
          if(keysCollected == 1){
            image_1.color = new Color32(255,253,148,255);
          }  
        }
        if(key_2){
          if(keysCollected == 2){
            image_2.color = new Color32(255,253,148,255);
          }  
        }
        if(key_3){
          if(keysCollected == 3){
            image_3.color = new Color32(255,253,148,255);
          }  
        }
        
    }
}
