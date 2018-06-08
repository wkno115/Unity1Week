using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour {
    public float FirstSpeed;
    public Runner runner;
    private float speed;
    private float seconds;
	// Use this for initialization
	void Start () {
        seconds = 0;
        speed = FirstSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        seconds += Time.deltaTime;
        if (seconds>10)
        {
            Debug.Log("加速");
            speed+=0.005f;
            seconds = 0;
        }
	}
    public float getSpeed()
    {
        return speed;
    }
    public bool PoseCheck()
    {
        Runner.POSE p = runner.getPose();
        switch (p)
        {
            case Runner.POSE.JUMPPING:
            case Runner.POSE.SLIDING:
                return true;
            default:
                return false;
        }
    }
}
