using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifleWeapon : MonoBehaviour
{
    int _damageDealt = 30;

    private void Start()
    {
        Screen.lockCursor = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
             Screen.lockCursor = false;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Screen.lockCursor = true;
            Ray mouseRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;

            if (Physics.Raycast(mouseRay, out hitInfo))
            {
                if (hitInfo.transform.gameObject.tag == "enemy")
                {
                    hitInfo.transform.GetComponent<enemyController>().damage(_damageDealt);
                }
            }
        }
    }
}
