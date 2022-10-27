using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoulBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxSouls(int souls)
    {
        slider.maxValue = souls;
        // slider.value = souls;
    }

    public void SetSouls(int souls)
    {
        slider.value = souls;
    }
}
