using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostBoltFollow : MonoBehaviour {

    public string holder;
    bool shot = false;
    Transform h;

    void Start()
    {
        h = GameObject.Find(holder).transform;
    }

    // Update is called once per frame
    

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
        {
            shot = true;
        }

        if (!shot)
        {
            transform.position = h.position;
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
