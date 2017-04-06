using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelections : MonoBehaviour {
    public int player1class;
    public int player2class;
    public int map;

    static PlayerSelections instance = null;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    public void player1selectMage()
    {
        player1class = 1;
    }

    public void player2selectMage()
    {
        player2class = 1;
    }

    public void player1selectWarrior()
    {
        player1class = 2;
    }

    public void player2selectWarrior()
    {
        player2class = 2;
    }

    public void Map1()
    {
        map = 1;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}