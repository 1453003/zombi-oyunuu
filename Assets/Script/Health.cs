using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] 
    int _maximumHealth = 100; 
    int _currentHealth = 0;
    public override string ToString()
    {
        return _currentHealth + " / " + _maximumHealth;
    }
    public bool IsDead { get { return _currentHealth <= 0; } }
    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = _maximumHealth;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Damage(int damageValue)
     { 
         _currentHealth -= damageValue;
        if (_currentHealth < 0)
         {
             _currentHealth = 0;
         }
        if (_currentHealth==0)
        {
            
                Animation a = GetComponentInChildren<Animation>();
                a.Stop();
            

            Destroy(GetComponent<Pla>());
            Destroy(GetComponent<PlayerAnimation>());
            Destroy(GetComponent<rifleWeapon>());
            Destroy(GetComponent<enemyController>());
            Destroy(GetComponent<CharacterController>());
            Destroy(GetComponentInChildren<EnemyAttack>());

            Ragdoll r = GetComponent<Ragdoll>();
            if (r != null)
            {
                r.OnDeath();
            }
        }
    } 
}
