using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    short playerNumber = 1;
    public float playerSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.name == "Player2")
        {
            playerNumber = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }
    void PlayerInput()
    {
        if(playerNumber == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
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
}
