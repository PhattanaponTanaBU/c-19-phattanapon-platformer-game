using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Slider HealthSlider;
    public Character Character;

    void Start()
    {
        HealthSlider.maxValue = Character.Health;
    }

    void Update()
    {
        if (HealthSlider.value != Character.Health)
        {
            HealthSlider.value = Character.Health;
        }

    }
}


