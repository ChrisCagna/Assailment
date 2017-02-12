using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public Rigidbody2D rb;
    
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       // print("update called");
        if (Input.GetKeyDown("space"))
        {

            print("Space pressed");
            rb.velocity = new Vector3(4, 0, 0);

        }
	}
}
