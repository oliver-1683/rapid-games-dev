using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colour_door_controal : MonoBehaviour
{

    public Texture enteryTexture;
    public GameObject leftdoor;
    public GameObject rightdoor;
    public Vector3 doormovment;


    private void OnTriggerEnter(Collider other)
    {
        MeshRenderer meshrenderer = other.GetComponent<MeshRenderer>();

        if (other.tag == "Player")
        {

            if (meshrenderer.materials[0].mainTexture == enteryTexture)
            {
                
                leftdoor.transform.position = leftdoor.transform.position + doormovment;
                rightdoor.transform.position = rightdoor.transform.position - doormovment;

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if( other.tag == "Player" )
        {
            leftdoor.transform.position = leftdoor.transform.position - doormovment;
            rightdoor.transform.position = rightdoor.transform.position + doormovment;

        }
    }

}
