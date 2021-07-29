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
    bool playerBoarding = false;
    Vector2 playerStoredPosition;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name + "hit ship");
        if (col.gameObject.name == "Player1")
        {
            playerBoarding = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerBoarding)
        {
            /* Some odd code for Movement control
            Vector3 targetDir;
            Vector2 currentDir;
            float xOffset = transform.position.x - player.transform.position.x;
            float yOffset = transform.position.y - player.transform.position.y;
            targetDir = new Vector3(xOffset, 0f, yOffset);
            currentDir = new Vector2(xOffset, yOffset);
            Quaternion rot = Quaternion.LookRotation(targetDir, Vector3.up);
            player.transform.rotation = Quaternion.Slerp(player.transform.rotation, rot, 0.05f);
            player.transform.Translate(currentDir.normalized * 0.01f);

            if(Vector2.Distance(player.transform.position, this.transform.position) < 1)
            {
                player.transform.position = transform.position;
                player.transform.rotation = this.transform.rotation;
                playerAnim.SetBool("sitting", true);
                playerOnShip = true;
                playerBoarding = false;
            }
            */
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log(playerBoarding);
                playerStoredPosition = player.transform.position;
                player.transform.position = transform.position;
                playerAnim.SetBool("sitting", true);
                playerOnShip = true;
                playerBoarding = false;
            }
            //player anim is sitting
            //player position center

        }
        if (playerOnShip)
        {
            player.transform.position = transform.position;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, 0, -1 * rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0, 1 * rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Debug.Log(playerBoarding);
                //Vector2 currentDir;
                //currentDir = new Vector2(2, 2);
             
                playerAnim.SetBool("sitting", false);
                player.transform.rotation = Quaternion.Euler(0, 0, 0);
                player.transform.position = playerStoredPosition;
                playerOnShip = false;
                playerBoarding = false;
            }
            
        }
    }
    
}
