using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Keys_UI : MonoBehaviour
{

    public static int keysCollected;

    private GameObject key_1;
    private GameObject key_2;
    private GameObject key_3;

    Image image_1;
    Image image_2;
    Image image_3;
    // Start is called before the first frame update
    void Start()
    {
        key_1 = GameObject.Find("keysCollected_1");
        image_1 = key_1.GetComponent<Image>();
        key_2 = GameObject.Find("keysCollected_2");
        image_2 = key_2.GetComponent<Image>();
        key_3 = GameObject.Find("keysCollected_3");
        image_3 = key_3.GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if(keysCollected == 1){
            image_1.color = new Color32(255,253,148,255);
        }
        else if(keysCollected == 2){
            image_2.color = new Color32(255,253,148,255);
        }
        else if(keysCollected == 3){
            image_3.color = new Color32(255,253,148,255);
        }
    }
}
