using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{

    public int kacinciKalp;

    void Start()
    {
        
    }

    void Update()
    {
        
        if (DropFruit.can < kacinciKalp)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        }
        
    }
}
