using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkBalls : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            //get all the balls in the game
            GameObject[] balls = GameObject.FindGameObjectsWithTag("Player");

            foreach(GameObject ball in balls)
            {
                //shrink the ball
                ball.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            }

            //move the power up away then destroy it
            transform.position = new Vector3(100, 100, 100);
            Destroy(gameObject, 2);
        }
    }
}
