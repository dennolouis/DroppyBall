using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shift : MonoBehaviour
{

    [SerializeField] float speed = 1;
    float direction;

    AudioSource audioSource;

    private void Start()
    {
        direction = Mathf.Floor(Random.Range(-1, 2));
        audioSource = GetComponent<AudioSource>();
        speed = Random.Range(speed * 0.7f, speed * 1.3f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(direction, 0, 0) * speed * Time.deltaTime);
        if(audioSource)
            audioSource.volume -= 0.06f * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        speed = -speed;
    }
}