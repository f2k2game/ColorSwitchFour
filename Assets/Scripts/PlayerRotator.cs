using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotator : MonoBehaviour {

    AudioSource clickSound;

    private void Start()
    {
        clickSound = GetComponent<AudioSource>();
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
            if(name == "LeftCircle"){
                transform.Rotate(0, 0, 90);
                clickSound.Play(0);
            }
            if(name == "RightCircle"){
                transform.Rotate(0, 0, -90);
                clickSound.Play(0);
            }
        }
    }
}
