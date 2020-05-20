using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousefollow : MonoBehaviour
{
    Vector2 mousepos;
    Rigidbody2D ufoRB;
    Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        mousepos = Input.mousePosition;
        velocity.y = Mathf.MoveTowards(velocity.y, roamingspeed, 1 * Time.fixedDeltaTime);
    }
}
