using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public int bumperForce = 800;
    private GameObject player;
    private GameObject player2;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("Player2");
    }

    /*public void OnCollissionEnter(Collider collider)
     {
         if(collider.gameObject == player)
         {
             player.GetComponent<Rigidbody>().AddExplosionForce(bumperForce, transform.position, 1);
         }
     }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            player.GetComponent<Rigidbody>().AddForce(0, 0, -bumperForce, ForceMode.Impulse);
            Debug.Log("done");
        }

        if (collision.gameObject == player2)
        {
            player2.GetComponent<Rigidbody>().AddForce(0, 0, -bumperForce, ForceMode.Impulse);
            Debug.Log("done2");
        }

    }

}
