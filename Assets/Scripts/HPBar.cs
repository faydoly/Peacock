using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPBar : MonoBehaviour
{
    [SerializeField] private TMP_Text textDP;
    private int maxvalue;

    private Slider _slider;
    public void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void SetUp (int maxvalue)
    {
        this.maxvalue = maxvalue;

        _slider.maxValue = maxvalue;
        _slider.value = maxvalue;

        Setvalue(maxvalue);
    }

    public void Setvalue (int value)
    {
        _slider.value = value;

        /*string p = value + "/" + maxvalue;
         * textDP.text = p;
        */

        textDP.text = value + "/" + maxvalue;
        //textDp.text = $"{value} / {maxvalue}";
    }
}
