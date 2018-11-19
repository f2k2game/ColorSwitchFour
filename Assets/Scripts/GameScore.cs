using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour {

    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    GameSession gs;

    // Use this for initialization
    void Start () {
        gs = FindObjectOfType<GameSession>();
        if (gs.score > gs.highScore)
        {
            gs.SetHighScore();
        }
        score.SetText(gs.score.ToString());
        highScore.SetText(gs.highScore.ToString());
    }
	

    public void GoToReplay()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToHome()
    {
        SceneManager.LoadScene(0);
    }
}
