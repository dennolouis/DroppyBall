using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class DuplicatePowerUp : MonoBehaviour
{

    //this power up duplicates the current selected ball

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            //this function is what instanciates another ball to the game
            Instantiate(FindObjectOfType<Player>().getSelectedBall(), transform.position , Quaternion.identity);
            audioSource.Play();

            //move the power up away then destroy it
            transform.position = new Vector3(100, 100, 100);
            Destroy(gameObject, 2);
        }
    }
}
