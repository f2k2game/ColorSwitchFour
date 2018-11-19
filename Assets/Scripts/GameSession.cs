using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {


    public int score;
    public int highScore;

    private void Awake()
    {
        int gsCount = FindObjectsOfType<GameSession>().Length;
        if(gsCount > 1) {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
        GetHighScore();
	}

    public void SetHighScore(){
        PlayerPrefs.SetInt("HighScore", score);
        GetHighScore();
    }

    private void GetHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
}
