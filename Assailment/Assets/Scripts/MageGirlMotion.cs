using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageGirlMotion : MonoBehaviour {

    float jumpHeight = 7;
    public float Speed = 2;
    Animator anim;
    Rigidbody2D rigi;
    bool jumpUsable = true;
    float cooldownTime =0f;
    bool repeating = false;
    public int player = 1;
    public Grounded GroundedScript; //this imports the grounded script into Grounded object
    // but NOT DONE YET, must attach the OBJECT with the GROUNDED SCRIPT to the mages scripts


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody2D>();
		
	}


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "MovingPlatform")
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


    void Update() {


       if( !anim.GetBool("mageDead")){

            if (player == 1) {

                if (Input.GetKeyDown("w") && GroundedScript.grounded)
                {
                    rigi.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                }

                GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, GetComponent<Rigidbody2D>().velocity.y);
                // edit, project settings, input
            }
            else if (player == 2)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow) && GroundedScript.grounded)
                {
                    rigi.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                }

                GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal 2") * Speed, GetComponent<Rigidbody2D>().velocity.y);
            }

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
}
