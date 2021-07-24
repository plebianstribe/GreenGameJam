using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretZone : MonoBehaviour
{
    public GameObject turret;
    public GameObject turretZone;
    public float rotationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        if(turret)
        {
            transform.position = turret.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -1 * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, 1 * rotationSpeed * Time.deltaTime);
        }
    }
}
