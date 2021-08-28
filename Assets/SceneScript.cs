using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // This is very important if we want to restart the level

public class SceneScript : MonoBehaviour {

    // This function is called every time another collider overlaps the trigger collider
    void OnTriggerEnter2D (Collider2D other)
    {
        // Checking if the overlapped collider is an enemy
        if (other.CompareTag ("End"))
        {
            // This scene HAS TO BE IN THE BUILD SETTINGS!!!
            SceneManager.LoadScene (3); // Your scene name
        }
    }
}