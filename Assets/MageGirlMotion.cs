using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageGirlMotion : MonoBehaviour {

    public float Speed = 2;
    Animator anim;
    Rigidbody2D rigi;
    bool jumpUsable = true;
    float cooldownTime =0f;
    bool repeating = false;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody2D>();
		
	}


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }


    void Cooldown()
    {
        cooldownTime += 0.5f;
        if (cooldownTime > 1.0f && cooldownTime<2.0)
        {
            jumpUsable = false;
        }
        else if (cooldownTime >= 10.0f)
        {
            jumpUsable = true;
            cooldownTime = 0f;
            CancelInvoke("Cooldown");
            repeating = false;
        }

    }

    void jump()
    {
        if (jumpUsable == true)
        {
            rigi.AddForce(new Vector2(0, 500f));
            if (repeating == false)
            {
                repeating = true;
                InvokeRepeating("Cooldown", 0, 0.1f);
                
            }
        }
    }


    void FixedUpdate () {

        if(Input.GetKey("w"))
        {
            jump();
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, 0);


        anim.SetFloat("hSpeed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }



    }
}
