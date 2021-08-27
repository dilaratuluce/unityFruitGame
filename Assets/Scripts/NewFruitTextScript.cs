using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewFruitTextScript : MonoBehaviour
{
    public Text newFruitText;


    float zaman;

    void Start()
    {
        newFruitText.text = "";
        zaman = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int score = ScoreScript.scoreNum;  // alttaki üç blok sayesinde uyarı mesajı bir saniye görünüp kayboluyor
        if ((score == 2 || score == 5 || score == 11 || score == 15 || score == 24 || score == 34 || score == 44 || score == 59) /* || (score > 40 && score % 15 == 14)*/ )  //elma için mesela, 3 olana kadar bu ifte dolanıp duruyor
        {
            newFruitText.text = "";
            zaman = Time.time + 1;
        }

        else if (zaman > Time.time)  // 3 olunca buraya giriyor, son dolandığında "zaman" değişkeni Time.time'dan bir saniye fazla olduğu için bu blokta bir saniye boyunca dolanıyor
        {
            newFruitText.text = "New Fruit Alert!";
            Debug.Log(score + " ----------------> new fruit yazisi çikti");
        }

        else
        {
            newFruitText.text = "";  // ikisi koşul da değilse ekranın boş olmasını istiyorum
        }

    }
}

//eskisi: 3 6 12 16 22

//yenisi: 3 6 12 16 25 35, (sonrası 15er): 45 60 75...