using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;

    public AudioSource rollingSound;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rollingSound = GetComponent<AudioSource>();
    }

   void PlayerControls()
    {

        if(Input.GetKey(left))
        {
            rb.AddForce(Vector3.left * speed);
        }

        if(Input.GetKey(right))
        {
            rb.AddForce(Vector3.right * speed);
        }

        if (Input.GetKey(up))
        {
            rb.AddForce(Vector3.forward * speed);
        }

        if(Input.GetKey(down))
        {
            rb.AddForce(Vector3.back * speed);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "speedBoost")
        {
            Debug.Log("speed boost");
            speed = 100;
            rb.AddForce(Vector3.forward * speed);
            Invoke("RegularSpeed", 1);
        }
    }

    void RegularSpeed()
    {
        speed = 20;
    }

    private void FixedUpdate()
    {
        PlayerControls();
    }

    private void Update()
    {
        if(rb.velocity.magnitude >= 0.1 && !rollingSound.isPlaying)
        {
            rollingSound.Play();
        }
    }
}
