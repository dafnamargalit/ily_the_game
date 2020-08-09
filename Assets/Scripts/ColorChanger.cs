using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update

    Color[] color = new Color[4];

    int index;
    
    float waitTime = 4.0f;
    float timer = 0.0f;
    void Start()
    {
        color[0] = new Color(0,0,1,0.25f);
        color[1] = new Color(1,0,0,0.25f);
        color[2] = new Color(1,0,1,0.25f);
        color[3] = new Color(0,1,0,0.25f);
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.fixedDeltaTime;
        if(timer > waitTime && index < 3){
            timer = timer - waitTime;
            index++;
        }
        else if(timer > waitTime){
            timer = timer - waitTime;
            index = 0;
        }
        this.GetComponent<SpriteRenderer>().color = color[index];
    }
}
