﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Grounded : MonoBehaviour
{

    Animator anim;

    public bool grounded;


    private void OnTriggerEnter2D(Collider2D other)
    {
        grounded = true;
        anim.SetBool("grounded", grounded);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        grounded = false;
        anim.SetBool("grounded", grounded);
    }

    private void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

}
