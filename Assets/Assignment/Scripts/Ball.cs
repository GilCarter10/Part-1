using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject target;
    public GameObject prefab;
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
            Destroy(prefab);
            Instantiate(prefab, origin, transform.rotation);

        }
    }
}
