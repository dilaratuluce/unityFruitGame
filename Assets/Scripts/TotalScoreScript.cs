using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScoreScript : MonoBehaviour
{

    public Text totalScore;
    
    void Start()
    {
        totalScore.text = "Your Score: " + ScoreScript.scoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
