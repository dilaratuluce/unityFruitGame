using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeActiveScript : MonoBehaviour
{
    public GameObject orangeToActivate;
    bool activated = false;
    public int orangeScoreToActivate;


    void Start()
    {
        orangeToActivate.SetActive(false);    
    }

    
    void Update()
    {
        if(activated == false && (ScoreScript.scoreNum >= orangeScoreToActivate))
        {
            orangeToActivate.SetActive(true);

            orangeToActivate.gameObject.transform.position = new Vector3(Random.Range(-5,5), 2, 0); //22 ağust
         
            activated = true;
            DropFruit.activeFruitNum += 1;
            Debug.Log("Orange aktive edildiii!");
        }
    }

}
