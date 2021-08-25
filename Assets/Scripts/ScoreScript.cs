using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreNum;
    public Text myScoreText;

    void Start()
    {
        scoreNum = 0;
        myScoreText.text = "Score: " + scoreNum;
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fruit")
        {
            scoreNum += 1;
            myScoreText.text = "Score: " + scoreNum;
        }
    }
}
