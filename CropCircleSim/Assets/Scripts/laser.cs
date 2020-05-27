using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
	public AudioSource lasersound;
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
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
	
	public void LaserGoPewPew()
	{
		lasersound.Play();
	}
	
	public void LaserStopPewPew()
	{
		lasersound.Stop();
	}
}
