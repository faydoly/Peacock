using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    [SerializeField] private HPBar hpbar;
    [SerializeField] private int maxHealth; //limit
    private int _health; //gameplay
    //*************************************************************
    [SerializeField] private int maxMana;
    private int _Mana;


    private void Awake()
    {
        _health = maxHealth;
        hpbar.SetUp(maxHealth);
    }

    public void CalculateHealth(int value)
    {
        _health += value;

        if (value >= maxHealth) _health = maxHealth;
        else if (value <= 0) _health = 0;

        hpbar.Setvalue(_health);
    }

    //**************************************************
    public void CalculateMana(int value)
    {
        _Mana += value;

        if (value >= maxMana) _Mana = maxMana;
        else if (value <= 0) _Mana = 0;
    }

    #region Debug

    [ContextMenu("Health/Set Health To One")]
    private void SetHealthToOne()
    {
        _health = 1;

        hpbar.Setvalue(_health);
    }

    #endregion
}
