using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class db : MonoBehaviour
{
    public GameObject database;
    void Start()
    {
        string path = Application.dataPath+"/Database/DB.txt";
        string satir = File.ReadAllLines(path)[0];
        database.GetComponent<Text>().text = satir;
    }
}
