using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{

    public static GameBehaviour Instance;
    public FadeInOut fadeInFadeOutScript;


    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneToMoveTo(){
        fadeInFadeOutScript.FadeToScene("Microbe");
        //SceneManager.LoadScene("Microbe");
    }

    public void sceneToMoveToBacteria(){
        SceneManager.LoadScene("Bacteria");
    }

    public void sceneToMoveToBlood(){
        SceneManager.LoadScene("Blood");
    }
}
