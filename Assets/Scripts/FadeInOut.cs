using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public Image fadeOutTexture;
    public float fadeSpeed = 1.0f; 

    void Start()
    {
        fadeOutTexture.color = new Color(fadeOutTexture.color.r, fadeOutTexture.color.g, fadeOutTexture.color.b, 1);
        FadeIn();
    }

    void FadeIn()
    {
        fadeOutTexture.CrossFadeAlpha(0.0f, fadeSpeed, false);
    }

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeOut(sceneName));
    }

    IEnumerator FadeOut(string sceneName)
    {
        fadeOutTexture.CrossFadeAlpha(1.0f, fadeSpeed - 0.2f, false);
        yield return new WaitForSeconds(fadeSpeed);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}