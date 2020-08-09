using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelOne(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        SceneManager.LoadScene("Level_One");
    }

    public void LevelTwo(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        SceneManager.LoadScene("Level_Two");
    }
}
