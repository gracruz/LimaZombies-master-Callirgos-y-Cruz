using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{


    public GameObject Normal;
    public GameObject Danado;
    public GameObject GameOver;
    

    public float temporizador;

    public float maxHealth;
    public Slider healthbar;

    private float mHealth;

    private void Start()
    {
        mHealth = maxHealth;
        GameOver.SetActive(false);
        Danado.SetActive(false);
       

    }

    private void OnCollisionEnter(Collision collisionEnemy)
    {
        if (collisionEnemy.gameObject.CompareTag("Enemigo pequeño"))
        {
            // Hubo una colision

            mHealth -= maxHealth * 0.025f;

            healthbar.value -= 0.025f;


            if (mHealth <= 0)
            {
                Debug.Log("Perdiste");
                GameOver.SetActive(true);
              
            }

            Normal.SetActive(false);
            Danado.SetActive(true);

            Invoke("VuelveNormal", temporizador);


        }
        if (collisionEnemy.gameObject.CompareTag("Enemigo grande"))
        {
            // Hubo una colision
            mHealth -= maxHealth * 0.07f;

            healthbar.value -= 0.07f;


            if (mHealth <= 0)
            {
                Debug.Log("Perdiste");
                GameOver.SetActive(true);
             

            }

            Normal.SetActive(false);
            Danado.SetActive(true);

            Invoke("VuelveNormal", temporizador);


        }





    }

    private void VuelveNormal()
    {
        Normal.SetActive(true);
        Danado.SetActive(false);

    }
}
