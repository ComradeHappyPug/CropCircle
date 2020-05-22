using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accuracybar : MonoBehaviour
{
    public GameObject bar;
    Vector3 localscale;
    public float length;
    Timer timecount;
    // Start is called before the first frame update
    void Start()
    {
        localscale = bar.transform.localScale;
        timecount = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timecount.time <=0)
        {
            localscale.x = length * (FindObjectOfType<GameManager>().accuracy);
            bar.transform.localScale = localscale;
        }
    }
}
