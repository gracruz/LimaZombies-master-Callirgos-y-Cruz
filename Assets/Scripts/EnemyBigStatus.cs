using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBigStatus : MonoBehaviour
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
            mHealth -= maxHealth * 0.20f;
            // 
            healthbar.value -= 0.20f;

            if (mHealth <= 0)
            {
                // Player.GetComponent<PlayerStatus>().AumentarVida();
                Destroy(gameObject);

            }

        }
    }
}
