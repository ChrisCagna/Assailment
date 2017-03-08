using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorMotion : MonoBehaviour {



    Animator anim;
    Rigidbody2D rigi;
    public GameObject blade;
    public GameObject shieldCollider;
    public Grounded GroundedScript;
    float jumpHeight = 7;
    public float Speed = 2;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform.parent;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.Keypad1))
        {

            anim.SetBool("slicing", true);
            blade.GetComponent<Collider2D>().enabled = true;
          //  blade.GetComponent<Transform>().position = new Vector3(0.319f, 0.006f, 0);

        }
        else
        {
            anim.SetBool("slicing", false);
            blade.GetComponent<Collider2D>().enabled = false;
        }

        if (Input.GetKey(KeyCode.Keypad0))
        {

            anim.SetBool("shieldUp", true);
            shieldCollider.GetComponent<Collider2D>().enabled = true;
        }
        else
        {
           anim.SetBool("shieldUp", false);
           shieldCollider.GetComponent<Collider2D>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && GroundedScript.grounded)
        {
            rigi.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal 2") * Speed, GetComponent<Rigidbody2D>().velocity.y);

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
