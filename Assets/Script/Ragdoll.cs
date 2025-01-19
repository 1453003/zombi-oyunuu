using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DisableRagdoll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DisableRagdoll()
    {
        Rigidbody[] allRigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody r in allRigidbodies)
        {
            r.isKinematic = true;
        }
    }
    void EnableRagdoll()
    {
        Rigidbody[] allRigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody r in allRigidbodies)
        {
            r.isKinematic = false;
        }

    }
    public void OnDeath()
    {
        EnableRagdoll();
    }
}
