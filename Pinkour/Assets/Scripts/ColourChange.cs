using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    float timeLeft;
    Color targetColor;

    void Update()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (timeLeft <= Time.deltaTime)
        {
            renderer.material.color = targetColor;
            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 1.0f;
        }
        else
        {
            renderer.material.color = Color.Lerp(renderer.material.color, targetColor, Time.deltaTime / timeLeft);
            timeLeft -= Time.deltaTime;
        }
    }
}
