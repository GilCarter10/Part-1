using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 movement = new Vector2(0, 6);
    Rigidbody2D rb;
    Boolean down;
    Boolean up;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        up = true;
        down = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.y < 2 && up)
        {
            rb.MovePosition(rb.position + movement * Time.deltaTime);
        } else if (rb.position.y > 2 && up)
        {
            down = true;
            up = false;
        }
        
        if (rb.position.y > -2 && down)
        {
            rb.MovePosition(rb.position + movement * Time.deltaTime * -1);
        }
        else if (rb.position.y < -2 && down)
        {
            down = false;
            up = true;
        }

    }
}
