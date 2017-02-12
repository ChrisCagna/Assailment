using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostBolt : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            transform.parent = null;
            transform.localPosition += new Vector3(.05f, 0, 0);
        }
    }
}
