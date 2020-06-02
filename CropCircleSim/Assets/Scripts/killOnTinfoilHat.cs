using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killOnTinfoilHat : MonoBehaviour
{
    Timer timescript;
    public AudioSource deathsound;
    // Start is called before the first frame update
    void Start()
    {
        timescript = FindObjectOfType<Timer>();
        deathsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //on character death
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("collision");
        if (collision.gameObject.tag == "tinfoil" && Input.GetMouseButton(0))
        {
            deathsound.Play();
            timescript.time = 0;
            Destroy(this.gameObject);

        }
    }
}
