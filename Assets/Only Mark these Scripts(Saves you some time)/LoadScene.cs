using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//function of this script is to ensure that the scene loads after the user beats the level


public class LoadScene : MonoBehaviour
{
    //amount of time that the user is in the scene before it loads to new scene
    public float delayBeforeLoad = 32f;

    // which scene to load
    public string sceneNameToLoad; 

    //variable to keep track of how long user is in scene
    private float timeElapsed;

    void Update()
    {
        //giving time elapsed the value of the time user is in scene
        timeElapsed = Time.timeSinceLevelLoad;

        //if the time you are in the scene is greater then the delay before load
        if (timeElapsed >= delayBeforeLoad)
        {
            //load scene with given name
            SceneManager.LoadScene(sceneNameToLoad);
        }

    }
}
