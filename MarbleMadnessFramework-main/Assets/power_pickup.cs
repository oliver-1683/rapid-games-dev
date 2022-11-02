using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_pickup : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "player")
        {
            other.gameObject.AddComponent<DestructionPower>();
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
