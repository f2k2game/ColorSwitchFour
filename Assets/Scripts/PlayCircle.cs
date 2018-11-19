using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayCircle : MonoBehaviour {

    public GameObject outerCircle;
    public GameObject innerCircle;
    public TextMeshProUGUI highScore;
    public float circleSpeed = 100f;

    private void Start()
    {
        highScore.SetText(FindObjectOfType<GameSession>().highScore.ToString());
    }

    // Update is called once per frame
    void Update () {
        outerCircle.transform.Rotate(0, 0, circleSpeed * Time.deltaTime);
        innerCircle.transform.Rotate(0, 0, -circleSpeed * Time.deltaTime);
    }

    private void OnMouseOver()
    {
        circleSpeed = 0f;
        if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(1);
        }
    }

    private void OnMouseExit()
    {
        circleSpeed = 100f;
    }
}
