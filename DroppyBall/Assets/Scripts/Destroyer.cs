using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    int amount = 3;

    private void OnCollisionEnter(Collision other)
    {
        if(amount <= 0) Destroy(this);

        if(other.gameObject.name[0] == 'C')
        {
            Destroy(other.gameObject);
            amount--;
        }
    }
}
