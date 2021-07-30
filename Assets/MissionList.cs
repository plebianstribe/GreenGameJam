using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionList : MonoBehaviour
{
    public List<string> missionTitleList = new List<string>();
    public List<string> missionDescriptionList = new List<string>();
    public List<string> missionTypeList = new List<string>();

    public List<int> missionTargetList = new List<int>();

    void Start()
    {
        missionTitleList.InsertRange(missionTitleList.Count, new string[] { "Trash Smash! 1", "Shell Yeah! 1", "Whats the Point ? 1", "Careful Cruising 1", "Trash Smash! 2", "Shell Yeah! 2", "Whats the Point ? 2", "Careful Cruising 2", "Trash Smash! 3", "Shell Yeah! 3", "Whats the Point ? 3", "Careful Cruising 3", "Trash Smash! 4", "Shell Yeah! 4", "Whats the Point ? 4", "Careful Cruising 4" });
        missionDescriptionList.InsertRange(missionDescriptionList.Count, new string[] { "Destroy 10 pieces of plastic", "Save 5 turtles", "Score 100 points", "Avoid any damage for 30 seconds", "Destroy 50 pieces of plastic", "Save 10 turtles", "Score 200 points", "Avoid any damage for 60 seconds", "Destroy 100 pieces of plastic", "Save 25 turtles", "Score 500 points", "Avoid any damage for 90 seconds", "Destroy 500 pieces of plastic", "Save 100 turtles", "Score 1000 points", "Avoid any damage for 120 seconds" });
        missionTypeList.InsertRange(missionTypeList.Count, new string[] { "Trash", "Turtle", "Score", "Death", "Trash", "Turtle", "Score", "Death", "Trash", "Turtle", "Score", "Death", "Trash", "Turtle", "Score", "Death" });
        missionTargetList.InsertRange(missionTargetList.Count, new int[] { 10, 5, 100, 30, 50, 10, 200, 60, 100, 25, 500, 90, 500, 100, 1000, 120 });
    }
}
