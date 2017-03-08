using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour {

    public Text gameTime;
    float t = 300;
    float g = 0;

    // Use this for initialization
    void Start () {
        gameTime.text = "Time: "+ t;

    }
	
	// Update is called once per frame
	void Update () {
        t -= Time.deltaTime;
        g = t;
        g = (Mathf.Round(t));
        gameTime.text = "Time: " + g;

    }
}
