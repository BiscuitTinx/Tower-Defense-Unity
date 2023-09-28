using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed ;

    public float  health = 100;

    public int worth = 50;

    public GameObject deathEffect;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }



    void Die()
    { 
        PlayerStats.Money += worth;              //Player gains money when enemy dies

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);                                  //Show a death effect and deletes the effect after 5 seconds


        Destroy(gameObject);
    }
}