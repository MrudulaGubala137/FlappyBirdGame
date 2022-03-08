using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    public void ScoreManager(int score)
    {
        score = score + 10;
        Debug.Log("Score:" + score);
    }
        
}
