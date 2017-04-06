using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    public GameObject Mage;
    public GameObject Mage2;
    public MageMotion MageMotionScript;

    public GameObject Warrior;
    public WarriorMotion WarriorMotionScript;

    public PlayerID playerIDScript;

    public PlayerSelections PlayerSelectionsScript;



    // Use this for initialization
    void Start()
    {
        PlayerSelectionsScript = GameObject.FindObjectOfType<PlayerSelections>();

        if (PlayerSelectionsScript.player1class == 1)
        {
            Instantiate(Mage, new Vector3(3.15f, 3.15f, 0), Quaternion.identity);
            playerIDScript = GameObject.FindObjectOfType<PlayerID>();
            playerIDScript.player = 1;
            playerIDScript.toon = 1;
        }

        if (PlayerSelectionsScript.player2class == 1 && PlayerSelectionsScript.player1class !=1)
        {
            Instantiate(Mage, new Vector3(12, 3.15f, 0), Quaternion.identity);
            playerIDScript = GameObject.FindObjectOfType<PlayerID>();
            playerIDScript.player = 2;
            playerIDScript.toon = 1;
        }

        if (PlayerSelectionsScript.player2class == 1 && PlayerSelectionsScript.player1class == 1)
        {
            Instantiate(Mage2, new Vector3(12, 3.15f, 0), Quaternion.identity);
            playerIDScript = GameObject.FindObjectOfType<PlayerID>();
            playerIDScript.player = 2;
            playerIDScript.toon = 1;
        }
        /////////////////////////////////////////////////////////////////
        if (PlayerSelectionsScript.player1class == 2)
        {
            Instantiate(Warrior, new Vector3(3.15f, 3.15f, 0), Quaternion.identity);
            playerIDScript = GameObject.FindObjectOfType<PlayerID>();
            playerIDScript.player = 1;
            playerIDScript.toon = 2;
        }

        if (PlayerSelectionsScript.player2class == 2 && PlayerSelectionsScript.player1class != 2)
        {
            Instantiate(Warrior, new Vector3(12, 3.15f, 0), Quaternion.identity);
            playerIDScript = GameObject.FindObjectOfType<PlayerID>();
            playerIDScript.player = 2;
            playerIDScript.toon = 2;
        }

        if (PlayerSelectionsScript.player2class == 2 && PlayerSelectionsScript.player1class == 2)
        {
            Instantiate(Warrior, new Vector3(12, 3.15f, 0), Quaternion.identity);
            playerIDScript = GameObject.FindObjectOfType<PlayerID>();
            playerIDScript.player = 2;
            playerIDScript.toon = 2;
        }


    }
	
	// Update is called once per frame
	void Update () {		
	}
}
