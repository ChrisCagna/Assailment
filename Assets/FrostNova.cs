using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostNova : MonoBehaviour {

    int counter = 0;
    float scale = 0f;
    float revert;
	// Use this for initialization
	void Start () {
		
	}

    void Cast()
    {
        {
            scale++;
            transform.localScale += new Vector3(scale, 0, 0);
            counter++;
            print("Grow");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("x"))
        {
            InvokeRepeating("Cast", 0f, 0.05f);           
        }
        if (counter > 10)
        {
            CancelInvoke("Cast");
            scale = 0f;
            transform.localScale -= new Vector3(66, 0, 0);
            counter = 0;

        }
		
	}
}
