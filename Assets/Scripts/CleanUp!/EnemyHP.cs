using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    private Animator _anim;

    [SerializeField] int EnemyHealthMax;
    [SerializeField] int EnemyHealth;

    private void Awake()
    {
        EnemyHealth = EnemyHealthMax;

        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(EnemyHealth <= 0)
        {
            _anim.SetBool("Dead", true);
        }
    }

    public void GotDamage(int damage)
    {
        EnemyHealth -= damage;
    }
}
