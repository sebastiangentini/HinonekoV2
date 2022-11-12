using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSouls : MonoBehaviour
{
    public int maxSouls = 9;
    public int currentSouls;
    public GameObject particulasAlmas;
    public GameObject particulasFuego;
    private bool almasIsActive = false;

    public SoulBar soulBar;

    void Start()
    {
        currentSouls = 0;
        soulBar.SetMaxSouls(maxSouls);        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Jiggler>() != null)
        {
            GainSouls(1);
        }
    }

    void GainSouls(int recharge)
    {
        currentSouls += recharge;
        soulBar.SetSouls(currentSouls);
        if (!almasIsActive)
        {
            particulasAlmas.SetActive(true);
            almasIsActive = true;
        }
        particulasAlmas.transform.localScale *= 1.1f;
        if (currentSouls >= 9)
        {
            Debug.Log("MaxSouls");
            particulasAlmas.SetActive(false);
            almasIsActive = false;
            particulasFuego.SetActive(true);
        }
    }
}
