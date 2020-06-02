/****************
 * By: Esther Strathy
 * 5/20/2020
 * Description: runs end of level script which counts up accuracy of player by counting which dots were destroyed 
 * 
 *****************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Timer timescript;
    float dotcount;
    float pathcount;
    public float accuracy;
    public float score;
    GameObject[] pauseObjects;
    public float[] levelscores;
    public float gamescore = 0;
	private int done = 0;
	public float totalScore = 5;
	//public bool level1star1 = false;
	//public bool level1star2 = false;
	//public bool level1star3 = false;
    // Start is called before the first frame update
    void Start()
    {
        //gets number of each type of dot
        dotcount = GameObject.FindObjectsOfType<dot>().Length;
        print(dotcount);

        pathcount = GameObject.FindObjectsOfType<path>().Length;
        print(pathcount);
        
        timescript = FindObjectOfType<Timer>();
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
        levelscores = new float[15];
    }

    // Update is called once per frame
    void Update()
    {
        if (timescript.time <= 0 && done == 0)
        {
            print("gameend");
            onlevelEnd();
			gamescorecalc();
			done = 1;
        }
        //gamescorecalc();
    }
    void onlevelEnd()
    {
        accuracydots();
        print(accuracy);
        Time.timeScale = 0;
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
		totalScore = score;
    }

    //finds accuracy by percentage of dots removed from map
    void accuracydots()
    {
        float pathaccuracy;
        float dotaccuracy;
        pathaccuracy = (1.0f -((float)GameObject.FindObjectsOfType<path>().Length / pathcount));
        print("pathcount:" + pathcount);
        print("pathcurrent:" + GameObject.FindObjectsOfType<path>().Length);
        dotaccuracy = (float)GameObject.FindObjectsOfType<dot>().Length / dotcount;
        accuracy = (pathaccuracy + dotaccuracy) / 2;
        score = accuracy * 1000f;
        levelscor();
    }

    void levelscor()
    {
        Scene scene = SceneManager.GetActiveScene();
        int i = scene.buildIndex; 
        levelscores[i] = score;
    }

    void gamescorecalc()
    {
        int i;
        for (i = 0; i < 15; i++)
        {
            gamescore += levelscores[i];
        }
        print(gamescore);
    }
}
