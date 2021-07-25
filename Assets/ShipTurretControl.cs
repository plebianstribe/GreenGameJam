using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTurretControl : MonoBehaviour
{
    //    public Collider2D shipCollider;
    //    public Collider2D playerCollider;

    public float rotationSpeed = 5.0f;
    public GameObject player;
    public Animator playerAnim;
    bool playerOnShip = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerOnShip);
        if (playerOnShip)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, 0, -1 * rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0, 1 * rotationSpeed * Time.deltaTime);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name + "hit ship");
        if (col.gameObject.name == "Player1")
        {
            playerOnShip = true;
            player.transform.position = transform.position;
            playerAnim.SetBool("sitting", true);
            //player anim is sitting
            //player position center
        }
    }
}
