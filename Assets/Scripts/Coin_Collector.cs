using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name.Equals("daf")){
            Destroy (gameObject);
            ScoreText.score += 10;
        }
    }
}
