using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    public Text health;
    public bool mageDead;
    float h = 100;
    Animator anim;
    public bool mageShieldUp;
    float t = 0;
    float restartTime = 3;

    // Use this for initialization
    void Start () {
        health.text = "Health = " + h;
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        health.text = "Health = " + h;

        if (Input.GetKeyDown("z"))
        {
            mageShieldUp = true;
            t = 4;
        }
        if (mageShieldUp)
        {
            t -= Time.deltaTime;
        }
        if (mageShieldUp && t <= 0)
        {
            mageShieldUp = false;
        }
        if (anim.GetBool("mageDead") || anim.GetBool("warriorDead"))
        {
            restartTime -= Time.deltaTime;
        }
        if (restartTime <= 0)
        {
            SceneManager.LoadScene("Main");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Projectile" && !Input.GetKey(KeyCode.Keypad0) && h>0)
        {
            h -= 10;
            Destroy(collision.gameObject);
        }

        if (collision.transform.tag == "Warrior Blade" && !mageShieldUp && h>0)
        {
            h -= 10;
            print("Hit");
            //Destroy(collision.gameObject);
        }
        if (h <= 0)
        {
            mageDead = true;
            anim.SetBool("mageDead", true);
            anim.SetBool("warriorDead", true);
        }


    }
}
