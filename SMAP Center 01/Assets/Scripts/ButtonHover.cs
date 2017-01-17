using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHover : MonoBehaviour {

    public int timeRemaining = 3;
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void countDown()
    {
        timeRemaining--;
        print(timeRemaining);
        if(timeRemaining<= 0)
        {
            playVideo();

            //Reset Timer
            CancelInvoke("countDown");
            timeRemaining = 3;
            print("timer reset");

        }
    }

    void playVideo()
    {
        Vector3 newPos = transform.position;
        ball.transform.position = newPos;

    }

    public void mouseOver()
    {
        InvokeRepeating("countDown", 1, 1);
    }

    public void mouseOut()
    {
        CancelInvoke("countDown");
        timeRemaining = 5;

    }

}
