using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;

public class KarakterOlum : MonoBehaviour
{
    public static float y;
    public float timer;
    public GameObject gameoverPanel;

    public string path, satir;
    
    // Start is called before the first frame update
    void Start()
    {
        gameoverPanel.SetActive(false);
        PlayerPrefs.SetInt("kontrol",0);
        path = Application.dataPath+"/Database/DB.txt";
        satir = File.ReadAllLines(path)[0];
    }
    // Update is called once per frame
    void Update()
    {
        if(y<-20.0f)
        {
            gameoverPanel.SetActive(true);
            timer+=1*Time.deltaTime;
            
            if(timer > 1.4f)
            {   
                //kontrol=true;
                if(PlayerPrefs.GetInt("Score")>int.Parse(satir))//şuanki skor kayıtlı skordan büyükse bu skoru kaydet
                {
                    var file = new List<string>(System.IO.File.ReadAllLines(path)); file.RemoveAt(0); File.WriteAllLines(path, file.ToArray());//İlk Satırı Siler
                    using (StreamWriter outputFile = new StreamWriter(path, true))//İlk Satıra Değer Atar
                    {
                        outputFile.WriteLine(PlayerPrefs.GetInt("Score"));
                    }

                }
                
                y=0;
                
                gameoverPanel.SetActive(false);
                SceneManager.LoadScene(2);
            }
        }
    }
}
