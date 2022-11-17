using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFadeIn : MonoBehaviour
{
    [SerializeField] private Animator FadeInController;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FadeInController.SetBool("PlayFadeIn", true);
        }
    }
}
