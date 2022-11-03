using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public float duration = 1f;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        Destroy(gameObject, duration);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {   
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
 