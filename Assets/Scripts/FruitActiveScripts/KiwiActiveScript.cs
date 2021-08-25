using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiwiActiveScript : MonoBehaviour
{
    public GameObject kiwiToActivate;
    bool activated = false;
    public int kiwiScoreToActivate;

    void Start()
    {
        kiwiToActivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (activated == false && ScoreScript.scoreNum >= kiwiScoreToActivate)
        {
            kiwiToActivate.SetActive(true);
            kiwiToActivate.gameObject.transform.position = new Vector3(Random.Range(-5, 5), 2, 0); //22 ağst
            activated = true;
            DropFruit.activeFruitNum += 1;
            Debug.Log("Kiwi aktive edildi!");
        }
    }
}
