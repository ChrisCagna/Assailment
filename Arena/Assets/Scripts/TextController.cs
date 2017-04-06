using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text P1HPtext;
    public Text P2HPtext;
    public int P1HP = 100;
    public int P2HP = 100;


	// Use this for initialization
	void Start () {
        P1HPtext.text = "Player 1\n"+ P1HP;
        P2HPtext.text = "Player 2\n"+ P2HP;

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Projectile2")
        {
            P1HP -= 10;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
