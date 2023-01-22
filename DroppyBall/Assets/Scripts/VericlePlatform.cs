using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VericlePlatform : MonoBehaviour
{
    [SerializeField] float speed = 10;

    //health is the number of times this platform goes up and down
    int health;

    void Start()
    {
        speed = Random.Range(speed * 0.5f, speed * 1.5f);
        health = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish")
        {
            if(health <= 0)
            {
                Destroy(gameObject, 5f);
                return;
            }

            speed = -speed;
            health--;
        }
    }

}
