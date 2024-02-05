using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidetrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "SceneTransitionTag")
        {
            print("Transition");
            GameBehaviour.Instance.sceneToMoveTo();
        }

        else if(collision.gameObject.tag == "Bacteria")
        {
            print("Transition");
            GameBehaviour.Instance.sceneToMoveToBacteria();
        }

        else if(collision.gameObject.tag == "Blood")
        {
            print("Transition");
            GameBehaviour.Instance.sceneToMoveToBlood();
        }
    }
}
