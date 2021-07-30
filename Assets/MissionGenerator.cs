using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionGenerator : MonoBehaviour
{
    MissionList ml;
    Score score;
    public GameObject player;

    //public GameObject ml;
    public Text descriptionText;
    public Text counterText;
    public string missionType;
    public int missionCounter;
    int missionTotal;
    //I'm using a coroutine to be sure the list in Script1 is created before I print the items in the list.
    /*IEnumerator Start()
    {
        ml.init();
        ml = GetComponent<MissionList>();
        yield return new WaitForEndOfFrame();
    }
    */
    void Start()
    {
        ml = GameObject.Find("MissionHeader").GetComponent<MissionList>();
        score = GameObject.Find("ScoreLabel").GetComponent<Score>();
    }
    public void updateMission()
    {
        if (ml.missionDescriptionList.Count > 0)
        {
            descriptionText.text = ml.missionDescriptionList[0];
            counterText.text = "0/" + ml.missionTargetList[0].ToString();
            missionType = ml.missionTypeList[0];
            missionCounter = 0;
            missionTotal = ml.missionTargetList[0];
            ml.missionDescriptionList.RemoveAt(0);
            ml.missionTargetList.RemoveAt(0);
            ml.missionTypeList.RemoveAt(0);
        }
    }

    public void completed()
    {
        //descriptionText.text = "Mission Completed!";
    }
    public void checkMissionCompleted()
    {
        if(missionType == "Score")
        {
            missionCounter = score.counter;
        }
        counterText.text = missionCounter.ToString()+"/" + missionTotal.ToString();
        if (missionCounter > missionTotal - 1)
        {
            updateMission();
        }

    }
    void Update()
    {
        Debug.Log("slist lengths are " + ml.missionDescriptionList.Count.ToString() + ", " + ml.missionTypeList.Count.ToString() + ", " + ml.missionTargetList.Count.ToString());
        if (descriptionText.text == "No more missions!")
        {
            updateMission();
        }
        checkMissionCompleted();
        Debug.Log(missionCounter);
    }
}
