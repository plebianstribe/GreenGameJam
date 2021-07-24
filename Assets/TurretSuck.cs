using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSuck : MonoBehaviour
{
    Transform pivot;
    float suctionSpeed;

    // Start is called before the first frame update
    void Start()
    {
        pivot = transform.parent;
        suctionSpeed = transform.parent.GetComponent<TurretZone>().suctionSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Trash1")
        {
            float height = pivot.transform.position.y - col.transform.position.y;
            float length = pivot.transform.position.x - col.transform.position.x;
            if(height < 0.2f && length < 0.2f)
            {
                Destroy(col.gameObject);
            }

            float angle = Mathf.Atan2(height, length);
            col.transform.Translate(Mathf.Cos(angle) * suctionSpeed * Time.deltaTime, Mathf.Sin(angle) * suctionSpeed * Time.deltaTime, 0);
        }
    }
}
