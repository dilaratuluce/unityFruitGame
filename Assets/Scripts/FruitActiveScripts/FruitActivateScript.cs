using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitActivateScript : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject orangePrefab;
    public GameObject pineapplePrefab;
    public GameObject cherryPrefab;
    public GameObject melonPrefab;
    public GameObject kiwiPrefab;

    int sayi;
    bool meyveKoyuldu;

    void Start()
    {

        meyveKoyuldu = false;
        sayi = 0;

    }

    
    void Update() //yenisi: 3 6 12 16 25 35, (sonrası 15er): 45 60 75...
    {
        int score = ScoreScript.scoreNum;
        if (score > 0 && meyveKoyuldu == false && (score == 3 || score == 6 || score == 12 || score == 16 || score == 25 || score == 35 || (score > 40 && score % 15 == 0)))
        {
            meyveKoyuldu = true;
            meyveKoy();
            Debug.Log(score + "--------------> meyveyi koydum");

            Debug.Log("meyve koyuldu true oldu");
        }

        else if (score == 4 || score == 7 || score == 13 || score == 17 || score == 26 || score == 36 || (score > 40 && score % 15 == 1) )
        {
            meyveKoyuldu = false;
            Debug.Log(score + " meyvekoyuldu false oldu yine");
        }

    }

    void meyveKoy()
    {

        if (sayi == 0)
        {
            Instantiate(orangePrefab, new Vector3(Random.Range(-5, 5), 2, 0), new Quaternion(0, 0, 0, 0));
            DropFruit.activeFruitNum += 1;
            Debug.Log("portakalı koydum");
            sayi += 1;
        }

        else if (sayi == 1)
        {
            Instantiate(pineapplePrefab, new Vector3(Random.Range(-5, 5), 2, 0), new Quaternion(0, 0, 0, 0));
            DropFruit.activeFruitNum += 1;
            Debug.Log("ananası koydum");
            sayi += 1;
        }

        else if (sayi == 2)
        {
            Instantiate(cherryPrefab, new Vector3(Random.Range(-5, 5), 2, 0), new Quaternion(0, 0, 0, 0));
            DropFruit.activeFruitNum += 1;
            Debug.Log("kirazı koydum");
            sayi += 1;
        }

        else if (sayi == 3)
        {
            Instantiate(melonPrefab, new Vector3(Random.Range(-5, 5), 2, 0), new Quaternion(0, 0, 0, 0));
            DropFruit.activeFruitNum += 1;
            Debug.Log("karpuzu koydum");
            sayi += 1;
        }

        else if (sayi == 4)
        {
            Instantiate(kiwiPrefab, new Vector3(Random.Range(-5, 5), 2, 0), new Quaternion(0, 0, 0, 0));
            DropFruit.activeFruitNum += 1;
            Debug.Log("kiwiyi koydum");
            sayi += 1;
        }

        else if (sayi == 5)
        {
            Instantiate(applePrefab, new Vector3(Random.Range(-5, 5), 2, 0), new Quaternion(0, 0, 0, 0));
            DropFruit.activeFruitNum += 1;
            Debug.Log("elmayı koydum");
            sayi = 0;
        }
    }
}


