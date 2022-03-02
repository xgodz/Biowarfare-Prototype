using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    public Slider slider;

    public void SetHealthValue(float health)
    {
        slider.value = health;
    }

    public void SetMaxHealth(float health)
    {
        // we are setting the max health value of the slider to the passed health parameter
        slider.maxValue = health;

        // also setting the slider value to the health parameter
        slider.value = health;
    }
}
