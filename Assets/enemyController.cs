using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class enemyController : MonoBehaviour
{
    CharacterController _controller;
    Transform _player;

    private int maxhealth = 100;

    public int currentHealth = 0;

    [SerializeField] 
    float _moveSpeed = 5.0f;

    [SerializeField] 
     float _gravity = 2.0f; 
  
     float _yVelocity = 0.0f;
    void Start()
    {
        currentHealth = maxhealth;
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        _player = playerGameObject.transform;

        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 direction = _player.position - transform.position;
        direction.Normalize();

        Vector3 velocity = direction * _moveSpeed;

        if (!_controller.isGrounded)
        {
          _yVelocity -= _gravity;
        }
        
         velocity.y = _yVelocity;

        if (currentHealth <=0)
        {
            Destroy(this.gameObject);
        }

        direction.y = 0;

        transform.rotation = Quaternion.LookRotation(direction);

        _controller.Move(direction * Time.deltaTime);
    }

    public void damage(int damageValue)
    {
        currentHealth-=damageValue;
    }
}
