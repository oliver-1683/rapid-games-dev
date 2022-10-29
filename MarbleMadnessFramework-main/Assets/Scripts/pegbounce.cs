using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class pegbounce : MonoBehaviour
{
    
    public float bouncescale = 10.0f;


    private void  OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController =other.GetComponent<PlayerController>();
            Vector3 playerpos = playerController.transform.position;
            Vector3 pegpos = transform.position;

            Vector3 towardplayer = playerpos - pegpos;
            towardplayer.Normalize();

            playerController.RB.AddForce(towardplayer * bouncescale, ForceMode.Force);

        }
    }
}
