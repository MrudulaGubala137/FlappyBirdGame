using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    public int score;
   // public Text scoreText;
    // Start is called before the first frame update
    public void ScoreManager(int score)
    {
        score = score + 10;
        Debug.Log("Score:" + score);
       // scoreText.text = score.ToString();
       
    }
        
}
