using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 ballPos = new Vector2(0, 0);
    Vector2 carPos = new Vector2(-5, 0);
    public GameObject car;
    public GameObject ball;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == ball)
        {
            ball.transform.position = ballPos;
            car.transform.position = carPos;

    
        }

    }
}
