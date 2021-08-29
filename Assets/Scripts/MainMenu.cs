using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    static bool twoPlayer;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Oyundan çıktık.");
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void TryAgain()
    {
        if (twoPlayer)
        {
            SceneManager.LoadScene("2PlayerScene");
        }
        else
        {
            SceneManager.LoadScene("1PlayerScene"); 
        }
        
    }

    public void OnePlayer()
    {
        twoPlayer = false;
        SceneManager.LoadScene("1PlayerScene");
    }

    public void TwoPlayer()
    {
        twoPlayer = true;
        SceneManager.LoadScene("2PlayerScene");  
    }

    public void About()
    {
        SceneManager.LoadScene("InfoScene");
    }
}

