using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator anim;
    public float h, v;
    void Start()
    {
        anim=GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         h = Input.GetAxis("Horizontal");
         v = Input.GetAxis("Vertical");

        anim.SetFloat("Horizontal", h);
        anim.SetFloat("Vertical", v);

        if (!Mathf.Approximately(h, 0f) || !Mathf.Approximately(v, 0f))
        {
            anim.SetBool("Motion",true);
        }
        else
        {
            anim.SetBool("Motion", false);
        }
            
    }
}
