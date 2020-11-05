using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObjectPlayer1;
    public GameObject uiObjectPlayer2;

    public int winner = 0;

    private void Start()
    {
        uiObject.SetActive(false);
        uiObjectPlayer1.SetActive(false);
        uiObjectPlayer2.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if((player.gameObject.tag == "Player") && (winner==0))
        {
            uiObject.SetActive(true);
            uiObjectPlayer1.SetActive(true);
            winner = 1;
            StartCoroutine("ReturnToMenu");
        }

        if((player.gameObject.tag == "Player2") && (winner == 0))
        {
            uiObject.SetActive(true);
            uiObjectPlayer2.SetActive(true);
            winner = 2;
            StartCoroutine("ReturnToMenu");
        }
    }

    IEnumerator ReturnToMenu()
    {
        //Time.timeScale = 0.1f;
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
