using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGenerator : MonoBehaviour
{
    public GameObject zemin;
    Transform tr;
    public int zemin_sayisi;
    public float zemin_width, min_y, max_y;

    private void Start()
    {
        tr = zemin.GetComponent<Transform>();
        Vector3 yeni_konum = new Vector3();
        Vector2 yeni_scale = new Vector2();
        
        for (int i = 0; i < zemin_sayisi; i++)
        {
            yeni_scale.x = Random.Range(0.9f, 1.1f);
            yeni_scale.y = Random.Range(0.9f, 1.1f);
            tr.localScale = yeni_scale;
            
            yeni_konum.y += Random.Range(min_y, max_y);
            yeni_konum.x = Random.Range(-zemin_width, zemin_width);

            Instantiate(zemin, yeni_konum, Quaternion.identity);
        }
    }
}
