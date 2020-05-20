using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinFoilHats : MonoBehaviour
{
    Rigidbody2D TinFoilHat;
    Vector2 velocity;
    public float roamingspeed = 20f;
    public float roamingacceleration = 10f;
    public float roamtimelimit;
    bool changedirection = false;
    int direction;
    float timer; 
    // Start is called before the first frame update
    void Start()
    {
        TinFoilHat = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        roaming();
    }

    void roaming()
    {
        //picks random direction
        float timelim = Random.Range(0f, roamtimelimit);


        if (changedirection == false)
        {
            direction = Random.Range(1, 4);
            changedirection = true;
        }


        if (timer < timelim && changedirection)
        {
            //up
            if (direction == 1 && TinFoilHat.transform.position.y < 4.5f)
            {
                velocity.y = Mathf.MoveTowards(velocity.y, roamingspeed, roamingacceleration * Time.fixedDeltaTime);
                TinFoilHat.velocity = new Vector2(0f, velocity.y);
            }
            //down
            else if (direction == 2 && TinFoilHat.transform.position.y > -4.5f)
            {
                velocity.y = Mathf.MoveTowards(velocity.y, -roamingspeed, roamingacceleration * Time.fixedDeltaTime);
                TinFoilHat.velocity = new Vector2(0f, velocity.y);
            }
            //right
            else if (direction == 3 && TinFoilHat.transform.position.x < 4.5f)
            {
                velocity.x = Mathf.MoveTowards(velocity.x, roamingspeed, roamingacceleration * Time.fixedDeltaTime);
                TinFoilHat.velocity = new Vector2(velocity.x, 0f);
            }
            //left
            else if (direction == 4 && TinFoilHat.transform.position.x > -4.5f)
            {
                velocity.x = Mathf.MoveTowards(velocity.x, -roamingspeed, roamingacceleration * Time.fixedDeltaTime);
                TinFoilHat.velocity = new Vector2(velocity.x, 0f);
            }
            timer += Time.deltaTime;
            print("velocityx" + velocity.x + "velocityy" + velocity.y);
        }
        else
        {
            timer = 0f;
            changedirection = false;
            TinFoilHat.velocity = new Vector2(0f, 0f);
        }
    }
}
