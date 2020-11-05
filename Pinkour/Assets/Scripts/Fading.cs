using UnityEngine;
using UnityEngine.SceneManagement;

public class Fading : MonoBehaviour
{
    public Animator anim;

    private int levelToLoad;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeToLevel(2);
        }
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        anim.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
