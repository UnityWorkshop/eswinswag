using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
