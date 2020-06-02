using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelselectScore : MonoBehaviour
{
    Text scoretxt;
    float gamescore = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoretxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "score "+ (int)FindObjectOfType<GameManager>().gamescore;
    }
    
  
}
