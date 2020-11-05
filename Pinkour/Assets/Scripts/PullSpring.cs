using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSpring : MonoBehaviour
{
    string inputButtonName = "Pull";
    float distance = 50;
    float speed = 1;
    GameObject ball;
    float power = 2000;

    private bool ready = false;
    private bool fire = false;
    private float moveCount = 0;

    void OnCollisionEnter(Collision _other)
    {
        if (_other.gameObject.tag == "Ball")
        {
            ready = true;
        }
    }

    void Update()
    {

        if (Input.GetButton(inputButtonName))
        {
            //As the button is held down, slowly move the piece
            if (moveCount < distance)
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
                moveCount += speed * Time.deltaTime;
                fire = true;
            }
        }
        else if (moveCount > 0)
        {
            //Shoot the ball
            if (fire && ready)
            {
                Rigidbody ball = GetComponent<Rigidbody>();
                ball.transform.TransformDirection(Vector3.forward * 10);
                ball.AddForce(0, 0, moveCount * power);
                fire = false;
                ready = false;
            }
            //Once we have reached the starting position, fires
            transform.Translate(0, 0, 20 * Time.deltaTime);
            moveCount -= 20 * Time.deltaTime;
        }

        // Ensure we don't go past the end
        if (moveCount <= 0)
        {
            fire = false;
            moveCount = 0;
        }
    }
}
