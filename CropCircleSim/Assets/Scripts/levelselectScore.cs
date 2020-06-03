/*
 * All content © 2020 DigiPen (USA) Corporation, all rights reserved.
 * 
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelselectScore : MonoBehaviour
{
	Text scoretxt;
	//public int overallGameScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoretxt = GetComponent<Text>();
		//overallGameScore += (int)FindObjectOfType<GameManager>().totalScore;
    }

    // Update is called once per frame
    void Update()
    {
		//overallGameScore = (int)FindObjectOfType<GameManager>().totalScore;
        scoretxt.text = "score "+ (int)FindObjectOfType<GameManager>().totalScore;
		
		//if(FindObjectOfType<GameManager>().level1star1 == true)
		//{
		//	scoretxt.text = "one star";
		//}
    }
    
  
}
