using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorMotion : MonoBehaviour {

    private float Speed = 3;
    private float jumpForce = 300f;

    Animator anim;

    public GameObject blade;


    public Grounded GroundedScript;
    public int player;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        blade = FindObjectOfType<Blade>().gameObject;
        player = GetComponent<PlayerID>().player;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (anim.GetBool("dead") == false)
        {
            if (anim.GetBool("shieldUp") == true)
            {
                Speed = 1;
            }
            else if(anim.GetBool("shieldUp")== false)
            {
                Speed = 3;
            }

            if (player == 1)

            {
                //movement
                GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, GetComponent<Rigidbody2D>().velocity.y);

                anim.SetFloat("hSpeed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

                if (GetComponent<Rigidbody2D>().velocity.x > 0)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                }
                else if (GetComponent<Rigidbody2D>().velocity.x < 0)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                }

                //jump
                if (Input.GetKeyDown(KeyCode.W) && GroundedScript.grounded)
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
                }

                //shield
                if (Input.GetKey(KeyCode.C))
                {
                    anim.SetBool("shieldUp", true);
                }
                else
                {
                    anim.SetBool("shieldUp", false);
                }

                //slashing
                if (Input.GetKey(KeyCode.F))
                {
                    anim.SetBool("slashing", true);
                    blade.GetComponent<BoxCollider2D>().enabled = true;

                }
                else
                {
                    anim.SetBool("slashing", false);
                    blade.GetComponent<BoxCollider2D>().enabled = false;
                }

            }


            if (player == 2)
            {

                //movement
                GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal 2") * Speed, GetComponent<Rigidbody2D>().velocity.y);

                anim.SetFloat("hSpeed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

                if (GetComponent<Rigidbody2D>().velocity.x > 0)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                }
                else if (GetComponent<Rigidbody2D>().velocity.x < 0)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                }

                //jump
                if (Input.GetKeyDown(KeyCode.UpArrow) && GroundedScript.grounded)
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
                }

                //shield
                if (Input.GetKey(KeyCode.Keypad0))
                {
                    anim.SetBool("shieldUp", true);
                }
                else
                {
                    anim.SetBool("shieldUp", false);
                }

                //slashing
                if (Input.GetKey(KeyCode.Keypad1))
                {
                    anim.SetBool("slashing", true);
                    blade.GetComponent<BoxCollider2D>().enabled = true;

                }
                else
                {
                    anim.SetBool("slashing", false);
                    blade.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }

	}
}
