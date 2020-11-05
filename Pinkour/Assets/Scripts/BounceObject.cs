using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceObject : MonoBehaviour
{
    float explosionStrength = 100;

    private void OnCollisionEnter(Collision _other)
    {
        _other.rigidbody.AddExplosionForce(explosionStrength, this.transform.position, 5);
    }
}
