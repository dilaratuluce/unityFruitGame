using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PineappleActiveScript : MonoBehaviour
{
    public GameObject pineappleToActivate;
    bool activated = false;
    public int pineappleScoreToActivate;


    void Start()
    {
        pineappleToActivate.SetActive(false);
    }


    void Update()
    {
        if (activated == false && (ScoreScript.scoreNum >= pineappleScoreToActivate))
        {
            pineappleToActivate.SetActive(true);
            pineappleToActivate.gameObject.transform.position = new Vector3(Random.Range(-5, 5), 2, 0); //22 ağst
            activated = true;
            DropFruit.activeFruitNum += 1;
            Debug.Log("Pineapple aktive edildiii!");
        }
    }

}