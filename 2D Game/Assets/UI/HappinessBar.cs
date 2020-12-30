using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHappiness(int happiness)
    {
        slider.maxValue = happiness;
        slider.value = happiness / 2;
    }

    public void SetHappiness(int happiness) 
    {
        slider.value = happiness / 2;
    }
}