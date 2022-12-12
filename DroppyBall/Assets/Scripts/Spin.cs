using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] int speed = 10;
    [SerializeField] bool x = false;
    [SerializeField]bool y = true;
    [SerializeField] bool z = false;

    float direction;

    private void Start()
    {
        direction = Random.Range(0, 100) <= 50 ? 1 : -1;
        if(Random.Range(0, 100) <= 80) direction = 0;
        speed = Random.Range(speed - 5, speed + 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x ? direction: 0, y? direction: 0, z ? direction : 0) * speed * Time.deltaTime);
    }
}