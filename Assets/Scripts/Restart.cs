using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame(){
        Keys_UI.keysCollected = 0;
        ScoreText.score = 0;
        
        SceneManager.LoadScene("Level_One");
    }
}
