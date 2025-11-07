using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreMenuManager : MonoBehaviour
{
    public Text score;

    public void Start()
    {
        score.text = PlayerPrefs.GetInt("Score").ToString();
    }

    public void Update()
    {
        
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void replay()
    {
        KarakterOlum.y=0;
        SceneManager.LoadScene(1);
    
    }
    public void quit()
    {
        Application.Quit();
    
    }
}
