using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour {

    int counter = 0;
    int counter2 = 0;


    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
	}

    void Cast()
    {
        if (counter < 10)
        {
            transform.localScale += new Vector3(.01f, 0, 0);
            counter++;
        }
        else if (counter >=10  && counter < 20)
        {
            transform.localScale -= new Vector3(.01f, 0, 0);
            counter++;
        }
        else
        {
            counter = 0;
            counter2++;

        }
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("z"))
        {
            rend.enabled = true;
            InvokeRepeating("Cast", 0f, 0.03f);
        }
        if (counter2 > 5)
        {
            CancelInvoke("Cast");
            rend.enabled = false;
            counter2 = 0;

        }


    }
}
