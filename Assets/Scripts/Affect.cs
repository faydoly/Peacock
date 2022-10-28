using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Affect : MonoBehaviour
{
    [SerializeField] private Stat stat;

    [Header("Health Relate Effect")]

    [SerializeField] private float timeBetweenHeal;

    private Coroutine _healthFX;

    private float _healthFXDuration;
    private bool _healthFXInProgress;
    //******************************************************
    [SerializeField] private float timeBetweenMana;
    private Coroutine _manaFX;
    private float _manaFXDuration;
    private bool _manaFXInProgress;
    //******************************************************

    private void Update()
    {
        if (_healthFXInProgress) _healthFXDuration += Time.deltaTime;
        //*******************************************************
        if (_manaFXInProgress) _manaFXDuration += Time.deltaTime;
    }

    public void HealthBuff(int power, float limiter)
    {
        if (_healthFX != null) StopCoroutine(_healthFX);

        _healthFX = StartCoroutine(Adrenaline(limiter, timeBetweenHeal, power));
    }

    //************************************************************
    public void PlusMana(int power, float limiter)
    {
        if (_manaFX != null) StopCoroutine(_manaFX);

        _manaFX = StartCoroutine(ManaBuff(limiter, timeBetweenMana, power));
    }

    IEnumerator Adrenaline(float limiter, float timeBetweenFX, int power)
    {
        _healthFXDuration = 0f;
        _healthFXInProgress = true;
        while (_healthFXDuration <= limiter)
        {
            stat.CalculateHealth(power);

            yield return new WaitForSeconds(timeBetweenFX);
        }
        _healthFX = null;
        _healthFXInProgress = false;
    }

        //**********************************************************
    IEnumerator ManaBuff(float limiter, float timeBetweenFX, int power)
    {
        _manaFXDuration = 0f;
        _manaFXInProgress = true;
        while (_manaFXDuration <= limiter)
        {
            stat.CalculateMana(power);
            yield return new WaitForSeconds(timeBetweenFX);
        }
        _manaFX = null;
        _manaFXInProgress = false;
    }
}


//ทำเกมอะไร+ระบบอะไร
//ก่อนเริ่มคลาสวันจันทร์