using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float _nextTimeAttackIsAllowed = -1.0f;

    [SerializeField] 
     float _attackDelay = 1.0f;
    [SerializeField] 
     int _damageDealt = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)    
    { 
        
            if (other.tag == "Player" && Time.time >= _nextTimeAttackIsAllowed)          
            {
                   Health playerHealth = other.GetComponent<Health>();
                   playerHealth.Damage(_damageDealt);
                   _nextTimeAttackIsAllowed = Time.time + _attackDelay;
        }

    } 
}
