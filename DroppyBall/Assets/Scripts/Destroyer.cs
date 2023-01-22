using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    //when this script is attached to a ball, it will destroy the first 3 platforms it touches then remove itself

    int amount = 3;

    private void OnCollisionEnter(Collision other)
    {
        //this removes the Destroyer script from the game object
        if(amount <= 0) Destroy(this);

        // 'C' becase the platform game object is a cylinder
        if(other.gameObject.name[0] == 'C')
        {
            Destroy(other.gameObject);
            amount--;
        }
    }
}
