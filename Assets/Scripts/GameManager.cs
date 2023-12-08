using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Initial Value")]
    public int totalScore;
    public int highScore;
    public int lastScore;

    [Header("InGame panel")]
    public Text txtScore;

    [Header("GameOver panel")]
    public Text txtLastScore;
    public Text txtHIghScore;


    void Update()
    {
        highScore = PlayerPrefs.GetInt("p_highScore");
        lastScore = PlayerPrefs.GetInt("p_lastScore");

        txtLastScore.text = lastScore.ToString();
        txtScore.text = totalScore.ToString();
        txtHIghScore.text = highScore.ToString();
    }
}