using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    Animator anim;
    public Text text;
    public Text health;
    public MageMotion MageMotionScript;

    public WarriorMotion WarriorMotionScript;

    public PlayerSelections playerSelections;

    public PlayerID playerIDScript;

    public LevelManager levelManager;
    private int lives = 3;
    private string player;
    private int toon;
    private bool playerAlive = true;
    float h = 100;
    float t = 0;


    // Use this for initialization
    void Start () {

        //playerSelections = FindObjectOfType<PlayerSelections>();
        //player = playerSelections.player1class.ToString();

        //MageMotionScript = GetComponent<MageMotion>();
        //WarriorMotionScript = GetComponent<WarriorMotion>();
        //player = MageMotionScript.player.ToString();
        //player = WarriorMotionScript.player.ToString();

        player = GetComponent<PlayerID>().player.ToString();
        toon = GetComponent<PlayerID>().toon;



        levelManager = FindObjectOfType<LevelManager>();

        text = GameObject.Find("P"+player+"HP").GetComponent<Text>();
        GetComponent<Health>().health = text;
        health.text = " Health = " + h;

        anim = GetComponent<Animator>();
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("entered start collider");
        if (toon == 1) 
        {


            if (collision.transform.tag == "Projectile" && playerAlive && !GetComponentInChildren<BubbleScript>().shieldUp)
            {
                h -= 10;
                Destroy(collision.gameObject);
            }

            else if (collision.transform.tag == "Projectile" && playerAlive && GetComponentInChildren<BubbleScript>().shieldUp)
            {
                Destroy(collision.gameObject);

            }
        }

        if (toon == 2)
        {
            Debug.Log("Entered Warrior Colider");

            if (collision.transform.tag == "Projectile" && playerAlive)
            {
                h -= 10;
                Destroy(collision.gameObject);
            }

        }

    }

    // Update is called once per frame
    void Update () {
        health.text = "Player "+player+"\nLives: "+ lives+ "\nHP: " + h;

        if (h <= 0 && playerAlive)
        {
            playerAlive = !playerAlive;
            print("Player " + player + " Died");
            lives--;
            t = 4;
        }
        if (!playerAlive)
        {
            anim.SetBool("dead", true);
            t -= Time.deltaTime;
            if (t <= 0 && lives <= 0)
            {
                levelManager.Loadlevel("Win");
            }
            if (t <= 0 && lives >= 1)
            {
                int x = Random.Range(1, 15);
                GetComponent<Transform>().position = new Vector3(x,3,0);
                playerAlive = true;
                anim.SetBool("dead", false);
                h = 100;
            }

            
        }
    }
}
