using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallProvider : MonoBehaviour {

    public GameObject Ball;
    GameObject Clone;
    public float xPos = 1.8f;
    public int ballCreated = 0;
    [HideInInspector]
    public int currentScore; 
    public TextMeshProUGUI score;
    public GameObject pauseUI;
    public Button pauseButton;
    public float gameSpeed = 0.03f;

    private void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update () {
        if(ballCreated == 0){
            CreateBall();
        }
        score.SetText(currentScore.ToString());
        if(currentScore > gameSpeed * 100f){
            gameSpeed += 0.02f;
        }
	}

    private void CreateBall()
    {
        for (int i = 1; i<=2 ;i++){
            ballCreated++;
            InstBall(i);
        }
    }

    private void InstBall(int i)
    {
        if(i == 1){
            Vector2 insPos = new Vector2(-xPos, transform.position.y);
            Instantiate(Ball, insPos, Quaternion.identity);
        }
        if(i == 2){
            Vector2 insPos = new Vector2(xPos, transform.position.y);
            Instantiate(Ball, insPos, Quaternion.identity);
        }
    }

    public void GoToPause() {
        Time.timeScale = 0;
        pauseButton.gameObject.SetActive(false);
        pauseUI.SetActive(true);
    }


    public void GoToResume()
    {
        pauseButton.gameObject.SetActive(true);
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }

}
