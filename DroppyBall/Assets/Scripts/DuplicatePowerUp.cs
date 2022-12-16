using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class DuplicatePowerUp : MonoBehaviour
{

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Instantiate(FindObjectOfType<Player>().getSelectedBall(), transform.position , Quaternion.identity);
            audioSource.Play();
            transform.position = new Vector3(100, 100, 100);
            Destroy(gameObject, 2);
        }
    }
}
