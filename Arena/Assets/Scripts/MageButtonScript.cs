using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MageButtonScript : MonoBehaviour {

    //public GameObject PlayerSelection;
    public PlayerSelections PlayerSelectionsScript;
    public Button button;

    // Use this for initialization
    void Start () {
        PlayerSelectionsScript = GameObject.FindObjectOfType<PlayerSelections>();
        button = GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);

	}
	
    void TaskOnClick()
    {
        Debug.Log("Clicked the button");
        PlayerSelectionsScript.player2class = 1;
    }
	// Update is called once per frame
	void Update () {
	}
}
