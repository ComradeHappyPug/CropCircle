﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Input.GetMouseButton(0))
            Destroy(this.gameObject);
    }
}
