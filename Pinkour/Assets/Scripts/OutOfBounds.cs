using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    Transform ball;

    private Vector3 startingPos;

    private void Start()
    {
        startingPos = ball.position;
    }

    private void OnCollisionEnter(Collision _other)
    {
        if (_other.gameObject.tag == "Player")
        {
            Debug.Log("hello P1");
            _other.rigidbody.velocity = Vector3.zero;
            _other.transform.position = startingPos;
        }
        if (_other.gameObject.tag == "Player2")
        {
            Debug.Log("hello P2");
            _other.rigidbody.velocity = Vector3.zero;
            _other.transform.position = startingPos;
        }
    }
}
