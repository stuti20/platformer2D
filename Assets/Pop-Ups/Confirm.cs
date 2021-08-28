using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Confirm : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
    {
        // Checking if the overlapped collider is an enemy
        if (other.CompareTag ("popup"))
        {
            // This scene HAS TO BE IN THE BUILD SETTINGS!!!
            SceneManager.LoadScene (2); // Your scene name
        }
    }
}
