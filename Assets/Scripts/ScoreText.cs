using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update

    public static int score;
    int old_score;
    Text mainText, endText;

    private GameObject text_score, end_score;
    void Start()
    {
        text_score = GameObject.Find("mainScore");
        // end_score = GameObject.Find("endScore");
        mainText = text_score.GetComponent<Text>();
        // endText = end_score.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(score != 0 && old_score != score){
            mainText.text = score.ToString();
            // endText.text = score.ToString(); 
            old_score = score;
        }
    }
}
