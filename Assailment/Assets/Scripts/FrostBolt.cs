using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FrostBolt : MonoBehaviour
{

    public GameObject bullet;
    public GameObject bulletPrefab;
    public GameObject bulletHolder;
    Animator anim;
    public int player = 1;
    float timerP1 = 2;
    float timerP2 = 2;


    // Use this for initialization
    void Start()
    {
        bullet = Instantiate(bulletPrefab, bulletHolder.transform.position, Quaternion.identity);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        if (timerP1 < 2)
        {
            bullet = Instantiate(bulletPrefab, bulletHolder.transform.position, Quaternion.identity); // Quaterion is the roation,
                                                                                                      // bullet.transform.parent = bulletHolder.transform;
            timerP1 = 2;
        }
        else if (timerP1 > 2) {
            timerP1 -= Time.deltaTime;
        }


        if (timerP2 < 2)
        {
            bullet = Instantiate(bulletPrefab, bulletHolder.transform.position, Quaternion.identity); // Quaterion is the roation,
                                                                                                      // bullet.transform.parent = bulletHolder.transform;
            timerP2 = 2;
        }
        else if (timerP2 > 2)
        {
            timerP2 -= Time.deltaTime;
        }




        if (player == 1 && !anim.GetBool("mageDead"))
        {
            if (Input.GetKeyDown("f"))
            {
                if(bullet == null)
                {
                    bullet = Instantiate(bulletPrefab, bulletHolder.transform.position, Quaternion.identity);
                }

                bullet.GetComponent<Rigidbody2D>().AddForce(transform.localScale.x * transform.right * -10, ForceMode2D.Impulse);
                bullet.transform.parent = null;
                timerP1 = 2.3f;

            }
        }
    }
}
