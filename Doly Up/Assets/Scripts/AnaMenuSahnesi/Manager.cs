using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void Play()
    {
        KarakterOlum.y=0;
        SceneManager.LoadScene(1);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
