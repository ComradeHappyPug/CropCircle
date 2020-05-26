/*
 * accuracybar.cs
 * By: Esther Strathy
 * 5/26/2020
 * Description: transforms bar 
 * 
 */




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accuracybar : MonoBehaviour
{
    public GameObject bar;
    Vector3 localscale;
    public float length;
    Timer timecount;
    bool gameend= false;
    // Start is called before the first frame update
    void Start()
    {
        localscale = bar.transform.localScale;
        timecount = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timecount.time <=0 && !gameend)
        {
            localscale.x = length * (FindObjectOfType<GameManager>().accuracy);
            bar.transform.localScale = localscale;
            bar.transform.position += new Vector3(-1*((length / 2) -(localscale.x/2)),0f,0f);
            gameend = true;
        }
    }
}
