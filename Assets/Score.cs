using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int counter;
    public Text scoreText;
    void Update()
    {
        scoreText.text = counter.ToString();
    }
}
