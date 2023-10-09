using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{   
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float groundCheckDistance = .6f;
    [SerializeField] private LayerMask whatIsGround;
    private bool movingRight = true;

    [Header("Combat Settings")]
    [SerializeField] private int maxHealth = 5;
    private int currentHealth;
    [SerializeField] private int damage = 1;

    private Rigidbody2D enemyRigidBody;
    private EnemySpawner spawner;

    // Start is called before the first frame update
    void Awake()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    public void Initialize(EnemySpawner spawnerReference){
       spawner = spawnerReference;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
