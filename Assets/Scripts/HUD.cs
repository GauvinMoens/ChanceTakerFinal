using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] Slider strenghtSlider;
    public static int matToggle = 0;

    private void Update()
    {
        SliderUpdate();
    }

    private void SliderUpdate()
    {
        float currentStrenght = Mathf.Lerp(strenghtSlider.value, ThrowDice.p_strenght, Time.deltaTime/0.8f);
        strenghtSlider.value = currentStrenght;
    }

    public void ResetStrenght()
    {
        ThrowDice.p_strenght = 0;
    }

    public void SwitchMaterialButton1()
    {
        matToggle = 0;
    }
    public void SwitchMaterialButton2()
    {
        matToggle = 1;
    }
}
