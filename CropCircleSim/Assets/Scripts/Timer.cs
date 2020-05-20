using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timelim = 5;
    public float length;
    public float time;
    public GameObject timer;
    Vector3 localscale;
    // Start is called before the first frame update
    void Start()
    {
        time = timelim;
        localscale = timer.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(time>0)
        {
            time -= Time.deltaTime;
            localscale.x = length * time/timelim;
            timer.transform.localScale = localscale;
        }
    }
}
