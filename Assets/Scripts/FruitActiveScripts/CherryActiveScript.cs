using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryActiveScript : MonoBehaviour
{
    public GameObject cherryToActivate;
    bool activated = false;
    public int cherryScoreToActivate;

    void Start()
    {
        cherryToActivate.SetActive(false);
    }

    
    void Update()
    {
        if (activated == false && (ScoreScript.scoreNum >= cherryScoreToActivate))
        {
            cherryToActivate.SetActive(true);
            cherryToActivate.gameObject.transform.position = new Vector3(Random.Range(-5, 5), 2, 0); //22 ağst
            activated = true;
            DropFruit.activeFruitNum += 1;
            Debug.Log("Cherry aktive edildiii!");
        }
    }
}

