using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


//purpose of this script is to load a new given scene when user clicks button that is hostintg this script



public class ButtonScript1 : MonoBehaviour
{ 
    public void loadLevel(int LevelsIndex)
    {
        //load given scene
        SceneManager.LoadScene(LevelsIndex);
    }
        
        

}