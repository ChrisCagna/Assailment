using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeFollow : MonoBehaviour {

    public string holder;
    bool shot = false;
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
