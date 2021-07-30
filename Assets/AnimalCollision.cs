using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCollision : MonoBehaviour
{
    public GameObject player;
    string playerName;
    MissionGenerator mg;
    Score score;

    // Start is called before the first frame update
    void Start()
    {
        playerName = player.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == playerName)
        {
            Destroy(gameObject);
            missionUpdater("Mission1");
            missionUpdater("Mission2");
            missionUpdater("Mission3");
        }
    }

    void missionUpdater (string hi)
    {
        mg = GameObject.Find(hi).GetComponent<MissionGenerator>();
        if (mg.missionType == "Turtle")
        {
            mg.missionCounter += 1;
        }
        score = GameObject.Find("ScoreLabel").GetComponent<Score>();
        score.counter += 120;
    }
}
