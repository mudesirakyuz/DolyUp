using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yonetici : MonoBehaviour
{
    public Text skor;
    void Start()
    {
        
    }

    void Update()
    {
        skor.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
