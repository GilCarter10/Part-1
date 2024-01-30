using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class BallSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    Vector2 origin = new Vector2(0, 0);

    void Start()
    {
        Instantiate(prefab, origin, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
