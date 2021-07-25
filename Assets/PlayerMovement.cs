using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    short playerNumber = 1;
    public float playerSpeed = 1;
    public GameObject ship;
    public Animator anim;
    Collision2D colour;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }
    void PlayerInput()
    {
        if(anim.GetBool("sitting"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                anim.SetBool("sitting", false);
            }
            transform.rotation = ship.transform.rotation;
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (anim.GetBool("sitting"))
                {
                    anim.SetBool("sitting", false);
                }
                else
                {
                    anim.SetBool("sitting", true);
                }
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            }
        }
    }
    /*
    void checkCollision(Collision2D col)
    {
        if (col != null && col.gameObject.name == "Ship")
        {
            Debug.Log(col.gameObject.name + "hit Player");
            anim.SetBool("sitting", true);
            transform.position = ship.transform.position;
        }
    }
    */
}
