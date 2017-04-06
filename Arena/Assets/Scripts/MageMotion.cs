using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageMotion : MonoBehaviour {

    private float Speed = 3;
    private float jumpForce = 300f;

    Animator anim;

    public Grounded GroundedScript;
    public int player;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        player = GetComponent<PlayerID>().player;
    }

    // Update is called once per frame
    void Update()
    {


        if (player == 1 && !anim.GetBool("dead"))

        {
            //movement
            GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, GetComponent<Rigidbody2D>().velocity.y);

            anim.SetFloat("hSpeed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

            if (GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            //jump
            if (Input.GetKeyDown(KeyCode.W) && GroundedScript.grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            }

        }
        if (player == 2 && !anim.GetBool("dead"))
        {
            //movement
            GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal 2") * Speed, GetComponent<Rigidbody2D>().velocity.y);

            anim.SetFloat("hSpeed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

            if (GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            //jump
            if (Input.GetKeyDown(KeyCode.UpArrow) && GroundedScript.grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            }

        }
    }
}
