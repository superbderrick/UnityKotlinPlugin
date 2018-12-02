using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingManager : MonoBehaviour {

    public int timerTestValue = 0;
    public float speed = 3.0f;
    public GameObject captionObject;
	// Use this for initialization
	void Start () {
        Debug.Log("Cycle Check stat called ");

        captionObject = GameObject.Find("derrickCaption");
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.UpArrow)) {
            captionObject.transform.Translate(0, 0, -speed * Time.deltaTime);
        } else if(Input.GetKey(KeyCode.RightArrow)) {
            captionObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("left");
            captionObject.transform.Translate(0, 0, speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            captionObject.transform.Translate(0, 0, speed * Time.deltaTime);
        } 

    }
}
