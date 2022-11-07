using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] int EnemyHealthMax;
    [SerializeField] int EnemyHealth;

    private void Awake()
    {
        EnemyHealth = EnemyHealthMax;
    }

    public void TakeDamage(int damage)
    {
        EnemyHealth -= damage;
    }
}
