using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    public AudioClip deathAudio;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        if (deathAudio)
        {
            AudioSource.PlayClipAtPoint(deathAudio, transform.position);
        }
        Destroy(gameObject);
    }
}
