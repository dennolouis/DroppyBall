using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkBalls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject[] balls = GameObject.FindGameObjectsWithTag("Player");

            foreach(GameObject ball in balls)
            {
                ball.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            }

            transform.position = new Vector3(100, 100, 100);
            Destroy(gameObject, 2);
        }
    }
}
