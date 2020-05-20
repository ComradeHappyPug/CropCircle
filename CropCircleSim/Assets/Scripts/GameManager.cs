/****************
 * By: Esther Strathy
 * 5/20/2020
 * Description: runs end of level script which counts up accuracy of player by counting which dots were destroyed 
 * 
 *****************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Timer timescript;
    int dotcount;
    // Start is called before the first frame update
    void Start()
    {
        timescript = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timescript.time == 0)
        {
            onlevelEnd();
        }
    }
    void onlevelEnd()
    {

    }

    void accuracydots()
    {
            float accuracy; 
    }
}
