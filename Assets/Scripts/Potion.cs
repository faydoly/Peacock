using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    [SerializeField] private int power;
    [SerializeField] private float duration;

    [SerializeField] private Affect affect;

    [SerializeField] private PotionType type;

    private enum PotionType
    {
        Health,
        Stamina,
        FireResistance,
        Poison
    }

    private void UsePotion()
    {
        switch (type)
        {
            case PotionType.Health: // : = {
                affect.HealthBuff(power, duration);
                break; // = }
            case PotionType.Stamina:
                affect.PlusMana(power, duration);
                break;
            case PotionType.FireResistance:
                break;
            case PotionType.Poison:
                affect.HealthBuff(-power, duration);
                break;
        }
    }

    private PlayerWalk _playerWalk;

    private void Awake()
    {
        _playerWalk = new PlayerWalk();
    }

    private void OnEnable()
    {
        _playerWalk.Enable();
    }

    private void OnDisable()
    {
        _playerWalk.Disable();
    }

    private void Start()
    {
        _playerWalk.Player.Interact.started += _ => UsePotion();
    }
}
