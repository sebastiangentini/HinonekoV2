using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSouls : MonoBehaviour
{
    public int maxSouls = 9;
    public int currentSouls;

    public SoulBar soulBar;

    void Start()
    {
        currentSouls = 0;
        soulBar.SetMaxSouls(maxSouls);        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Souls"))
        {
            GainSouls(1);
        }
    }

    void GainSouls(int recharge)
    {
        currentSouls += recharge;
        soulBar.SetSouls(currentSouls);
    }
}
