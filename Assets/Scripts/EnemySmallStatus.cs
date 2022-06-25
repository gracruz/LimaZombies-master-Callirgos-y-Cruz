using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySmallStatus : MonoBehaviour
{
    public GameObject Player;
    public float maxHealth;
    public Slider healthbar;

    private float mHealth;

    private void Start()
    {
        mHealth = maxHealth;
    }

    private void OnCollisionEnter(Collision collisionExplosion)
    {
        if (collisionExplosion.gameObject.CompareTag("Explosion"))
        {
            // Hubo una colision
            mHealth -= maxHealth * 0.40f;
           // 
            healthbar.value -= 0.40f;

            if (mHealth <= 0)
            {
               // Player.GetComponent<PlayerStatus>().AumentarVida();
                Destroy(gameObject);

            }

        }
    }
}
