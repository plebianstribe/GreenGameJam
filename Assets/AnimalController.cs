using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class AnimalController : MonoBehaviour
{
    public Rigidbody2D rb;
    public double x_vel;
    public double y_vel;
    public double direction;
    public bool trapped = false;
    public double health; 
    System.Random random = new System.Random();
    [SerializeField] private AnimalHealth healthBar;

    // Start is called before the first frame update
    void Start()
    {   
        //Random random = new Random();
        
        // This is the code for random direction
        this.x_vel = random.NextDouble();
        this.y_vel = Math.Sqrt(1 - this.x_vel*this.x_vel);
        this.x_vel *= 2 * random.Next(0,2) - 1;
        this.y_vel *= 2 * random.Next(0,2) - 1;
        this.direction = Math.Atan2(this.x_vel, this.y_vel);
        rb.rotation =  - Convert.ToSingle(this.direction * (180 / Math.PI));
        
        // Setting velocity to test
        //this.x_vel = 0;
        //this.y_vel = 1;

        // Setting health and despawn
        this.health = 10.0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.trapped) {
            rb.velocity = new Vector2(Convert.ToSingle(this.x_vel), Convert.ToSingle(this.y_vel));
        } else {
            rb.velocity = new Vector2(Convert.ToSingle(random.NextDouble() * 2 - 1), Convert.ToSingle(random.NextDouble() * 2 - 1));
            //rb.MoveRotation( Convert.ToSingle(random.NextDouble() * (2 * random.Next(0,2) - 1))*10);
            rb.rotation =  - Convert.ToSingle(this.direction * (180 / Math.PI)) - (Convert.ToSingle(random.NextDouble() * (2 * random.Next(0,2) - 1))*10) ;
            this.drainHealth();
        }
        if (this.health<=0) {
            Destroy(rb.gameObject);
        }

    }
    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.tag == "Trash1") {
            this.trapped = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Trash1") {
            this.trapped = false;
            rb.rotation =  - Convert.ToSingle(this.direction * (180 / Math.PI));
        }
    }
    private void drainHealth() {
        this.health -= 0.005;
        var healthFloat = Convert.ToSingle(this.health/10);
        healthBar.setSize(healthFloat);
    }
}
 