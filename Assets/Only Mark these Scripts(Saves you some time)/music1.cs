using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//purpose of this script is to play music while playing the game



public class music1 : MonoBehaviour
{
    void Awake()
    {
        //creating array, objects in array are game objects with the tag "music"
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");

        //if the length of the array is greater then one
        if (objs.Length > 1)
        {
            //destroy the game object
          Destroy(this.gameObject);
        }
        //do not destroy the game object that is already in the array
        DontDestroyOnLoad(this.gameObject);
        
        

    }
}