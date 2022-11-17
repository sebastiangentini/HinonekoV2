using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CieloFadeOut : MonoBehaviour
{
    [SerializeField] private Animator CieloFadeOutController;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CieloFadeOutController.SetBool("CieloFadeOut", true);
        }
    }
}
