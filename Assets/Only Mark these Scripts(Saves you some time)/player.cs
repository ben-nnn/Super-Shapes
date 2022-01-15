using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * purpose: to allow player to move, set it so that when the player collides it loads the fail screen
 * this script is the same as all player scripts (player1a, player1b, player1c etc.)
 */


public class player1a : MonoBehaviour
{
    //speed that player moves
    public float moveSpeed = 400f;

    //movement
    float movement = 0f;

    // Update is called once per frame
    void Update()
    {
        //saying that user uses left and right arrow keys to move player
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        //saying the player rotates around the center
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //when player collides with object, load the fail screen
        SceneManager.LoadScene("fail1a");
    }


}
