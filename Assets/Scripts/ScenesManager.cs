using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;


    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        Lab,
        Microbe
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadMicrobe()
    {
        SceneManager.LoadScene(Scene.Microbe.ToString());
    }

    public void LoadLab()
    {
        SceneManager.LoadScene(Scene.Lab.ToString());
    }
}
