using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] float distance;
    [SerializeField] Transform face;

    private RaycastHit _hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(face.position, face.forward, out _hit, distance))
            {
                if (_hit.transform.tag == "Enemy")
                {
                    EnemyHP enemyHP;
                    _hit.transform.TryGetComponent(out enemyHP);

                    enemyHP.GotDamage(damage);
                }
            }
        }
    }
}
