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
    float dotcount;
    float pathcount;
    // Start is called before the first frame update
    void Start()
    {
        //gets number of each type of dot
        dotcount = GameObject.FindObjectsOfType<dot>().Length;
        print(dotcount);

        pathcount = GameObject.FindObjectsOfType<path>().Length;
        print(pathcount);
        
        timescript = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timescript.time <= 0)
        {
            print("gameend");
            onlevelEnd();
        }
    }
    void onlevelEnd()
    {
        print(accuracydots());
    }

    //finds accuracy by percentage of dots removed from map
    float accuracydots()
    {
        float pathaccuracy;
        float dotaccuracy;
        float accuracy;
        pathaccuracy = (1.0f -((float)GameObject.FindObjectsOfType<path>().Length / pathcount));
        print("pathcount:" + pathcount);
        print("pathcurrent:" + GameObject.FindObjectsOfType<path>().Length);
        dotaccuracy = (float)GameObject.FindObjectsOfType<dot>().Length / dotcount;
        accuracy = (pathaccuracy + dotaccuracy) / 2;
        return accuracy;
    }
}
