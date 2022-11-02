using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_obsticle : MonoBehaviour
{

    Vector3 startPosition;
    float objectHeight;

    bool movingup = true;
    bool movingdown = false;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        objectHeight = GetComponent<Collider>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (movingup)
        {
            Vector3 modifyposition = transform.position;
            modifyposition.y = modifyposition.y + 0.1f;
            transform.position = modifyposition;
        }

        if (movingdown)
        {
            Vector3 modifyposition = transform.position;
            modifyposition.y = modifyposition.y - 0.1f;
            transform.position = modifyposition;
        }

        if (transform.position.y > startPosition.y + objectHeight)
        {
            movingup = false;
            movingdown = true;
        }

    }
}
