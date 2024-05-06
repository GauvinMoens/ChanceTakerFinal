using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] Slider strenghtSliderP1;
    [SerializeField] Slider strenghtSliderP2;
    public static int matToggle = 0;


    private void Update()
    {
        SliderUpdate();
    }

    private void SliderUpdate()
    {
        float currentStrenght = Mathf.Lerp(strenghtSliderP1.value, ThrowDice.p_strenght, Time.deltaTime/0.25f);
        strenghtSliderP1.value = currentStrenght;
        float currentStrenghtP2 = Mathf.Lerp(strenghtSliderP2.value, ThrowDice1.p_strenghtP2, Time.deltaTime / 0.25f);
        strenghtSliderP2.value = currentStrenghtP2;
    }

    public void ResetStrenghtP1()
    {
        ThrowDice.p_strenght = 0;
    }

    public void ResetStrenghtP2()
    {
        ThrowDice1.p_strenghtP2 = 0;
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
