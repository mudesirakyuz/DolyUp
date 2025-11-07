using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zemin : MonoBehaviour
{
    public float ziplama_kuvveti;
    public bool temas_edildi_mi;
    public bool ziplatanZemin;
    int ziplatanZeminIhtimali;
    Animator anim;

    private void Start()
    {
        PlayerPrefs.SetInt("Score",0);
        anim = GetComponent<Animator>();
        ziplatanZeminIhtimali = Random.Range(1, 11);

        if (ziplatanZeminIhtimali == 1)
        {
            anim.SetBool("ZipladiMi", true);
            ziplama_kuvveti = 18f;
            ziplatanZemin = true;
        }
        else
        {
            ziplama_kuvveti = 12f;
            ziplatanZemin = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)//Sert Temas
    {
        if (collision.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 ziplama_velocity = rb.velocity;
                ziplama_velocity.y = ziplama_kuvveti;
                rb.velocity = ziplama_velocity;

                if (temas_edildi_mi==false)
                {
                    if (ziplatanZemin)
                    {
                        PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+3);
                        ziplatanZemin = false;
                    }
                    else
                    {
                        PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+1);
                    }
                    temas_edildi_mi = true;
                }

                anim.SetBool("DokunduMu", true);
                Destroy(gameObject, 1f);
            }
        }
    }
}
