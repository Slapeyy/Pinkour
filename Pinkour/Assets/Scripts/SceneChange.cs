using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //public float delay = 10;
    public string NewLevel = "GameScene";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay());
    }

    IEnumerator LoadLevelAfterDelay()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(NewLevel);
    }
}
