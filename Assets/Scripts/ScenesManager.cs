using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
    }
}
