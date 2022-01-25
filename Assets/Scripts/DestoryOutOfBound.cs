using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBound : MonoBehaviour
{
    private float rightBound;
    private float leftBound;
    // Start is called before the first frame update
    void Start()
    {
        rightBound = 18f;
        leftBound = -18f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }else if(transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        
    }
}
