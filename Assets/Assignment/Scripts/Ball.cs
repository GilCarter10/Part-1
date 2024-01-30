using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject target;
    Vector2 carPos = new Vector2(-5, 0);
    public GameObject car;
    Vector2 origin = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == target)
        {
            gameObject.transform.position = origin;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            car.transform.position = carPos;
            Instantiate(gameObject, origin, transform.rotation);
            Destroy(gameObject);

     

    }

}
