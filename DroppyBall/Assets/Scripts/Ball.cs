using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    //Ball neeeds a rigidbody so we can apply physics
    Rigidbody rb;
    
    //reference to the player so that we can 
    Player player;

    //speed that the ball moves
    [SerializeField] float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        //get the referrences
        rb =  GetComponent<Rigidbody>();
        player = FindObjectOfType<Player>();

        //each time a ball is spawn, we add a life to the player
        player.AddLife();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            MoveRight();
        else if (Input.GetKey(KeyCode.A))
            MoveLeft();
    }

    void MoveLeft()
    {
        //stop the velocity so that before we move so we dont add too much force
        StopMotion();
        //transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed, Space.World);
        rb.AddForce(new Vector3(-1, 0, 0) * speed);
    }

    void MoveRight()
    {
        //stop the velocity so that before we move so we dont add too much force
        StopMotion();
        //transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed, Space.World);
        rb.AddForce(new Vector3(1, 0, 0) * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        //add money if collided with the currency game object
        if(other.gameObject.tag == "Currency")
        {
            player.AddCurrency(5);
            Destroy(other.gameObject);
        }
    }

    void StopMotion()
    {
        //stop velocity
        Vector3 velocity = rb.velocity;
        velocity.x = 0;

        Vector3 angularVelocity = rb.angularVelocity;
        angularVelocity.x = 0;

        rb.velocity = velocity;
        rb.angularVelocity = angularVelocity;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        //when the ball reaches the top of the screen, destroy it and deduct a life
        if(other.gameObject.tag == "Finish")
        {
            player.DeductLife();
            Destroy(gameObject);
        }
    }

   
    private void OnTriggerExit(Collider other)
    {
        //the score adds after the ball passes through a tripper in the platforms
        if(other.gameObject.tag == "ScoreTrigger")
            player.AddScore(1);
    }

}
