using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accuracybar : MonoBehaviour
{
    public GameObject bar;
    Vector3 localscale; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Timer>().time <=0)
        {
            bar.transform.localScale = localscale;
        }
    }
}
