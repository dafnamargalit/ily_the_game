using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update

    public static int score;
    int old_score;
    Text text;

    private GameObject text_score;
    void Start()
    {
        text_score = GameObject.Find("score");
        text = text_score.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(score != 0 && old_score != score){
            text.text = score.ToString(); 
            old_score = score;
        }
    }
}
