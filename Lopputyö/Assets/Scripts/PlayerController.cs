using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5.0f;
    private float turnspeed = 100.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    public ParticleSystem particleExplosion;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {              
            // This is where we get player input
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);       
            // We turn the vehicle
            transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);          
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            particleExplosion.Play();
        }
    }
}
