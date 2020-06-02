using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stardisp : MonoBehaviour
{
    public float percentagereq;
    Timer timecount;
    // Start is called before the first frame update
    void Start()
    {
        timecount = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timecount.time <= 0 && FindObjectOfType<GameManager>().accuracy <percentagereq/100f)
        {
            Destroy(this.gameObject);
        }
		//else
		//{
		//	FindObjectOfType<GameManager>().level1star1 = true;
		//}
    }
}
