using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



//this code is the same as the code for "Hexagon", and "Pentagon" script.

//purpose of this script is to have the shape shrink


public class Square : MonoBehaviour
{
    //setup for linking rigidbody
    public Rigidbody2D rb;

    //setting how fast the shape shrinka
    public float shrinkSpeed = 3f;
    
    void Start()
    {
        //sets random orientation to spawn the shape in at
        rb.rotation = Random.Range(0f, 360f);
        //sets transform
        transform.localScale = Vector3.one * 10f;
    }

    void Update()
    {
        //makes the shape shrink
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        //if the size is smaller then 0.05f
        if (transform.localScale.x <= .05f)
        {
            //destroy gameObject
            Destroy(gameObject);
        }
    }
}