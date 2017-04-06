using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

    public string holder;
    Transform h;

	// Use this for initialization
	void Start () {
        h = GameObject.Find(holder).transform;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = h.position;
    }
}
