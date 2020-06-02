using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoretext : MonoBehaviour
{
    Text scoretxt;
    // Start is called before the first frame update
    void Start()
    {
        scoretxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "" + (int)FindObjectOfType<GameManager>().score;
    }
}
