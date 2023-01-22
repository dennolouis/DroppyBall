using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : MonoBehaviour
{
    //this powerup adds the destroyer script to the ball
    // TODO: should probably change Player tag to Ball
     private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.AddComponent(typeof(Destroyer));

            transform.position = new Vector3(100, 100, 100);
            Destroy(gameObject, 2);
        }
    }
}
