using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour
{
    float vertical;
    float horizontal;
    public float speed = 100;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector2 force1 = transform.right * horizontal * speed * Time.deltaTime;
        rb.AddRelativeForce(force1);
        Vector2 force2 = transform.up * vertical * speed * Time.deltaTime;
        rb.AddRelativeForce(force2);
    }
}
