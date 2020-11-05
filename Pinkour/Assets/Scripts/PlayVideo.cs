using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;
    public GameObject Player1;
    public GameObject Player2;


    // Start is called before the first frame update
    void Start()
    {
        Player1.GetComponent<PlayerMovement>().enabled = false;
        Player2.GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(StartVideo());
    }

    IEnumerator StartVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
        audioSource.Play();
        yield return new WaitForSeconds(5);
        Destroy(videoPlayer);
        Player1.GetComponent<PlayerMovement>().enabled = true;
        Player2.GetComponent<PlayerMovement>().enabled = true;
    }
}
