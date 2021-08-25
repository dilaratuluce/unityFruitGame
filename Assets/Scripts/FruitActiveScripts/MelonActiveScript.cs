using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonActiveScript : MonoBehaviour
{
    public GameObject melonToActivate;
    bool activated = false;
    public int melonScoreToActivate;

    void Start()
    {
        melonToActivate.SetActive(false);
    }

    
    void Update()
    {
        if (activated == false && ScoreScript.scoreNum >= melonScoreToActivate)
        {
            melonToActivate.SetActive(true);
            melonToActivate.gameObject.transform.position = new Vector3(Random.Range(-5, 5), 2, 0); //22 ağst
            activated = true;
            DropFruit.activeFruitNum += 1;
            Debug.Log("Melon aktive edildi!");
        }
    }
}
