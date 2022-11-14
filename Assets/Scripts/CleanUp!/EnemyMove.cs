using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;


public class EnemyMove : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public Transform bulletPosition;

    public LayerMask whatIsGround, whatIsPlayer;

    public GameObject bullet;

    //public float TimeToLive = 2f;

    public float health;

    //Patrolling (ลาดตระเวน)
    public Vector3 walkPoint;
    private bool walkPointSet;
    public float walkPointRange;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange)
        {
            Patrolling();
        }
    }

    private void Patrolling() //เดินลาดตระเวน
    {
        if (!walkPointSet)
        {
            SearchWalkPoint();
        }

        if (walkPointSet) //เซ็ตจุดเดิน
        {
            agent.SetDestination(walkPoint);

        }
        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }

    private void SearchWalkPoint() // สุ่มจุดที่จะเดินลาดตระเวน
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            //ทำการเรียกใช้คำสั่ง DestroyEnemy ภายในระยะเวลา 0.5 วินาที
            Invoke(nameof(DestroyEnemy), 0.5f * Time.deltaTime);
        }
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
