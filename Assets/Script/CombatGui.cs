using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Health _playerHealth;
    [SerializeField] 
     Texture2D _gameOverImage;
    public GameObject playerGameObject;
    void Start()
     {
         _playerHealth = playerGameObject.GetComponent<Health>();
        Debug.Log(_playerHealth);
     }
    void Update()
    {

    }
    void OnGUI()
     {
       if (_playerHealth.IsDead)
       {
            float x = (Screen.width - _gameOverImage.width) / 2;
                         float y = (Screen.height - _gameOverImage.height) / 2;
            GUI.DrawTexture(new Rect(x, y, _gameOverImage.width, _gameOverImage.height),
                             _gameOverImage);
        }
   }

// Update is called once per frame

}
