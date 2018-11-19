using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    Color[] ballColor = new Color[4];
    BallProvider bp;
    GameSession gs;
    public GameObject destroyEffect;

    // Use this for initialization
    void Start () {
        bp = FindObjectOfType<BallProvider>();
        gs = FindObjectOfType<GameSession>();
        Physics.gravity = new Vector3(0, bp.gameSpeed, 0);
        ballColor[0] = new Color(220f/255f, 0f/255f, 196f/255f); //pink
        ballColor[1] = new Color(0f/255f, 6f/255f, 228f/255f); //blue
        ballColor[2] = new Color(204f/255f, 0f/255f, 0f/255f); //red
        ballColor[3] = new Color(6f/255f, 206f/255f, 0f/255f); //green
        int randomArr = Random.Range(0, ballColor.Length);
        transform.GetComponent<SpriteRenderer>().color = ballColor[randomArr];
        if(randomArr == 0){
            tag = "pink";
        }
        else if(randomArr == 1){
            tag = "blue";
        }else if (randomArr == 2)
        {
            tag = "red";
        }else if (randomArr == 3)
        {
            tag = "green";
        }else {
            tag = "bug";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(tag == collision.collider.tag){
            bp.ballCreated--;
            bp.currentScore++;
            Destroy(gameObject);
            GameObject dp =  Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(dp, 1f);
        }else{
            //Debug.Log(collision.collider.tag);
            Destroy(gameObject);
            GameObject dp = Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(dp, 1f);
            gs.score = bp.currentScore;
            SceneManager.LoadScene(2);
            //Destroy(collision.collider.gameObject.GetComponentInParent<GameObject>());
            //Debug.Log("game Over");
        }
    }

}
