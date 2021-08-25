using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropFruit : MonoBehaviour
{
    public static int can;
    public static int activeFruitNum;

    void Start()
    {
        can = 3;
        activeFruitNum = 1; // apple
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fruit" && can > 0)
        {
            can -= 1;
            activeFruitNum -= 1;
            Debug.Log("Canın:" + can);

            if (collision.gameObject.tag == "fruit" && can == 0)
            {
                Debug.Log("Game Over! Your final score: " + ScoreScript.scoreNum);
                SceneManager.LoadScene("GameOver");
            }

            else if (activeFruitNum == 0)
            {
                Debug.Log("Game Over! Your final score: " + ScoreScript.scoreNum);
                SceneManager.LoadScene("GameOver");
            }
        }
     
    }
}
