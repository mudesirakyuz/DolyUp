using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareketi : MonoBehaviour
{
    public float harekethizi;
    private float yatayhareket;
    public bool sag,sol;
    Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);
            
            if (parmak.deltaPosition.x > 50.0f)
            {
                sag = true;
                sol = false;
            }
            if (parmak.deltaPosition.x < -50.0f)
            {
                sag = false;
                sol = true;
            }
        }

        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket*harekethizi*Time.deltaTime,rb.velocity.y);

        Vector2 yeniscale = transform.localScale;
        if (yatayhareket > 0)
        {
            yeniscale.x = 0.13f;
        }
        if (yatayhareket < 0)
        {
            yeniscale.x = -0.13f;
        }
        transform.localScale = yeniscale;
        KarakterOlum.y=rb.velocity.y;

        if(sag == true)
        {
            yeniscale.x = 0.13f;
        }
        if(sol == true)
        {
            yeniscale.x = -0.13f;
        }
    }
}
