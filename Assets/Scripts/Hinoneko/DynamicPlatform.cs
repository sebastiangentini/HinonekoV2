using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class DynamicPlatform : MonoBehaviour
{
    private Collider2D _collider2D;
    private GameObject _player;

    private void Awake()
    {
        _collider2D = GetComponent<Collider2D>();
        _player = FindObjectOfType<PlayerController>().gameObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _collider2D.enabled = false;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _collider2D.enabled = true;
        }
    }
}
