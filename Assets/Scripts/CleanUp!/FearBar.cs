using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearBar : MonoBehaviour
{
    private Slider Bar;

    private float lessValue;

    public void Awake()
    {
        Bar = GetComponent<Slider>();
    }

    public void SetUpFear(int lessvalue)
    {
        this.lessValue = lessvalue;
        Bar.value = lessvalue;

        SetFearvalue(lessValue);
    }

    public void SetFearvalue(float value)
    {
        Bar.value = value;
    }
}
