using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody rb;

    [SerializeField] float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb =  GetComponent<Rigidbody>();
        //rb.AddForce(new Vector3(1, 0, 0) * force);
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
        StopMotion();
        //transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed, Space.World);
        rb.AddForce(new Vector3(-1, 0, 0) * speed);
    }

    void MoveRight()
    {
        StopMotion();
        //transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed, Space.World);
        rb.AddForce(new Vector3(1, 0, 0) * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        // if(other.gameObject.tag == "Wall")
        // {
        //     rb.velocity = Vector3.zero;
        //     rb.angularVelocity = Vector3.zero;
        // }
    }

    void StopMotion()
    {
        Vector3 velocity = rb.velocity;
        velocity.x = 0;

        Vector3 angularVelocity = rb.angularVelocity;
        angularVelocity.x = 0;

        rb.velocity = velocity;
        rb.angularVelocity = angularVelocity;
    }

}
