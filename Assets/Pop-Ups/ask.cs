using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ask : MonoBehaviour
{
    public void Yes()
    {
        SceneManager.LoadScene(1);
    }

    public void No()
    {
        SceneManager.LoadScene(0);
    }
}
