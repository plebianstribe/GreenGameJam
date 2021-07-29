using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionGenerator : MonoBehaviour
{
    public Mission next;
    public GameObject player;

    public GameObject missionDisplay;
    public Text descriptionText;
    public Text counterText;
    int counter = 0;

    public void completed()
    {
        Debug.Log("Hello done!");
        descriptionText.text = "Mission Completed!";
    }
    public void checkMissionCompleted()
    {
        
        if(next.missionCounter > next.missionTarget-1)
        {
            Debug.Log(counter);
            counter +=  1;
            if (counter == 1)
            {
                completed();
            }
            if (counter > 300)
            {
                descriptionText.text = next.missionDescription;
                counterText.text = "0/" + next.missionTarget.ToString();
                next.missionTarget += 1;
                counter = 0;
            }
            
        }

    }
    void Update()
    {
        checkMissionCompleted();
    }
}
