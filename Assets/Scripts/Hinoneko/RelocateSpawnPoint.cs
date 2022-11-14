using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class RelocateSpawnPoint : MonoBehaviour
{
    public GameObject spawnPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            spawnPoint.transform.position = player.transform.position;
        }
    }
}
