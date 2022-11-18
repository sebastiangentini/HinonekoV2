using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPosition;
    public AudioClip shootAudio;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, bulletPosition.position, Quaternion.identity);
        if (shootAudio)
        {
            AudioSource.PlayClipAtPoint(shootAudio, transform.position);
        }
    }
}
