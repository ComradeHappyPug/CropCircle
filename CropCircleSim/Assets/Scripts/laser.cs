/*
 * laser.cs
 * By: Hunter Powrie
 * 6/2/2020
 * All content © 20xx DigiPen (USA) Corporation, all rights reserved.
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
	public AudioSource lasersound;
	public int playedsound = 0;
    SpriteRenderer sprite;
	Timer timescript;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
		timescript = FindObjectOfType<Timer>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && timescript.time>0)
        {
            sprite.color += new Color(0f, 0f, 0f, 255f);
			LaserGoPewPew();
        }
        else
		{
            sprite.color = new Color(255f, 255f, 255f, 0f);
			LaserStopPewPew();
		}
		//LaserGoPewPew();
    }
	//Players
	//
	public void LaserGoPewPew()
	{
		if(playedsound == 0)
		{
			lasersound.Play();
			playedsound++;
		}
		
	}
	
	public void LaserStopPewPew()
	{
		lasersound.Stop();
		playedsound = 0;
	}
}
