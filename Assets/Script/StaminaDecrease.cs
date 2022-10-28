using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaDecrease : MonoBehaviour
{
    public UnityEngine.UI.Slider mainSlider;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Decrease();
        } else
        {
            SelfIncrease();
        }

        
    }

    void Decrease()
    {
        mainSlider.value = mainSlider.value - 0.1f;

        if (mainSlider.value < 0.1)
        {
            mainSlider.value = 0;
        }
    }


    void SelfIncrease()
    {
        if (mainSlider.value > 0.1)
        {
            mainSlider.value = mainSlider.value + 0.0005f;
        }
    }
}
