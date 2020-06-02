/*
 * Mousefollow.cs
 * By: Esther Strathy
 * 6/2/2020
 * All content © 2020 DigiPen (USA) Corporation, all rights reserved.
 * 
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousefollow : MonoBehaviour
{
    Vector2 mousepos;
    Rigidbody2D ufoRB;
    public float movementspeed;
    Vector2 pos;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<Camera>();
        ufoRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //gets position of mouse and character
        mousepos = Input.mousePosition;
        pos = cam.ScreenToWorldPoint(mousepos);
        ufoRB.position = new Vector3 (pos.x,pos.y, 0); 

    }
}
