using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostBoltFollow : MonoBehaviour {

    public string holder;
    public GameObject smoke;
    bool shot = false;
    Transform h;
    public int player;

    void PuffSmoke()
    {
        GameObject smokePuff = Instantiate(smoke, transform.position, Quaternion.identity) as GameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Projectile")
        {
            PuffSmoke();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    void Start()
    {
        h = GameObject.Find(holder).transform;

        player = h.GetComponentInParent<MageMotion>().player;
    }

    // Update is called once per frame
    

	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown("f") && player == 1)
        {
            shot = true;
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) && player == 2)
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
