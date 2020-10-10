using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void HomeScreen(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        SceneManager.LoadScene("Home");
    }

    public void LevelsScreen(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        SceneManager.LoadScene("Level_Select");
    }
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

    public void LevelThree(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        SceneManager.LoadScene("Level_Three");
    }

    public void LevelFour(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        SceneManager.LoadScene("Level_Four");
    }

    public void LevelFive(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        SceneManager.LoadScene("Level_Five");
    }

    public void LevelSix(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        SceneManager.LoadScene("Level_Six");
    }
}
