using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballEnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D other)
    {
        // Checking if the overlapped collider is an enemy
        if (other.CompareTag ("Enemy"))
        {
            // This scene HAS TO BE IN THE BUILD SETTINGS!!!
            SceneManager.LoadScene(1); // Your scene name
        }
    }
}
