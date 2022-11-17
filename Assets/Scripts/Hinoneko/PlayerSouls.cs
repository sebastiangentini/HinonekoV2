using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSouls : MonoBehaviour
{
    public int maxSouls = 12;
    public int currentSouls;
    public GameObject particulasAlmas;
    public GameObject particulasFuego;
    public GameObject puertaCasaAbandonada;
    public Weapon weaponScript;

    private bool almasIsActive = false;

    public SoulBar soulBar;

    void Start()
    {
        currentSouls = 0;
        soulBar.SetMaxSouls(maxSouls);
        weaponScript = GetComponent<Weapon>();
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
        particulasAlmas.transform.localScale *= 1.07f;
        if (currentSouls >= 12)
        {
            Debug.Log("MaxSouls");
            particulasAlmas.SetActive(false);
            almasIsActive = false;
            particulasFuego.SetActive(true);
            puertaCasaAbandonada.SetActive(true);
            weaponScript.enabled = true;
        }
    }
}
