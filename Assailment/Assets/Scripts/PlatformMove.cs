using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {
    int counter = 0;
	// Use this for initialization
	void Start () {
        InvokeRepeating("move", 0f, 0.05f);

    }

    void move()
    {
        if (counter < 10)
        {
            transform.localPosition += new Vector3(.05f, 0, 0);
            counter++;
        }
        else if (counter >= 10 && counter < 20)
        {
            transform.localPosition -= new Vector3(.05f, 0, 0);
            counter++;
        }
        else
        {
            counter = 0;
                    }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
