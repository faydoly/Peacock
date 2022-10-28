using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private float speed;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
