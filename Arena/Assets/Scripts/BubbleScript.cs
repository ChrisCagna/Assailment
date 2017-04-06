using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour {

    private float cooldown = 10;
    private float dur = 3;
    public bool shieldUp = false;
    private int player;

	// Use this for initialization
	void Start () {
        player = GetComponentInParent<MageMotion>().player;
        GetComponent<SpriteRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("c") && cooldown >= 10 && player ==1)
        {
            shieldUp = true;
            cooldown = 0;
            GetComponent<SpriteRenderer>().enabled = shieldUp;
        }

        if (Input.GetKeyDown(KeyCode.Keypad0) && cooldown >= 10 && player == 2)
        {
            shieldUp = true;
            cooldown = 0;
            GetComponent<SpriteRenderer>().enabled = shieldUp;
        }

        if (cooldown < 10)
        {
            cooldown += Time.deltaTime;
        }


        if(shieldUp == true)
        {
            dur -= Time.deltaTime;

            if (dur <= 0)
            {
                shieldUp = false;
                GetComponent<SpriteRenderer>().enabled = shieldUp;
                dur = 3;

            }
        }
		
	}
}
