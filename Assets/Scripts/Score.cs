using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    [Header("Class Reference")]
    public GameManager gameManager;

    [Header("AudioElements")]
    public GameObject audioScoreObject;
    public AudioSource audioScore;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioScore = GameObject.Find("PointsSound").GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D actor)
    {
        if (actor.gameObject.CompareTag("Player"))
        {
            audioScore.Play();
            gameManager.totalScore += 1;
        }
    }

}