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

    public GameObject gatitoDormido;
    public GameObject gatitoDespierto;
    public GameObject particulasGatitoUI;

    public GameObject vidaUI01;
    public GameObject vidaUI02;
    public GameObject vidaUI03;
    public GameObject vidaUI04;
    public GameObject vidaUI05;
    public GameObject vidaUI06;
    public GameObject vidaUI07;
    public GameObject vidaUI08;
    public GameObject vidaUI09;
    public GameObject vidaUI10;
    public GameObject vidaUI11;
    public GameObject vidaUI12;


    private bool almasIsActive = false;

    public SoulBar soulBar;

    void Start()
    {
        currentSouls = 0;
        //soulBar.SetMaxSouls(maxSouls);
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
        //soulBar.SetSouls(currentSouls);
        if (!almasIsActive)
        {
            particulasAlmas.SetActive(true);
            almasIsActive = true;
            gatitoDormido.SetActive(false);
            gatitoDespierto.SetActive(true);
        }
        particulasAlmas.transform.localScale *= 1.07f;
        particulasGatitoUI.transform.localScale *= 1.07f;

        if (currentSouls >= 1)
        {
            vidaUI01.SetActive(true);
        }
        if (currentSouls >= 2)
        {
            vidaUI02.SetActive(true);
        }
        if (currentSouls >= 3)
        {
            vidaUI03.SetActive(true);
        }
        if (currentSouls >= 4)
        {
            vidaUI04.SetActive(true);
        }
        if (currentSouls >= 5)
        {
            vidaUI05.SetActive(true);
        }
        if (currentSouls >= 6)
        {
            vidaUI06.SetActive(true);
        }
        if (currentSouls >= 7)
        {
            vidaUI07.SetActive(true);
        }
        if (currentSouls >= 8)
        {
            vidaUI08.SetActive(true);
        }
        if (currentSouls >= 9)
        {
            vidaUI09.SetActive(true);
        }
        if (currentSouls >= 10)
        {
            vidaUI10.SetActive(true);
        }
        if (currentSouls >= 11)
        {
            vidaUI11.SetActive(true);
        }
        if (currentSouls >= 12)
        {
            vidaUI12.SetActive(true);
        }
        if (currentSouls >= 12)
        {
            particulasAlmas.SetActive(false);
            almasIsActive = false;
            particulasFuego.SetActive(true);
            puertaCasaAbandonada.SetActive(true);
            weaponScript.enabled = true;
        }

    }
}
