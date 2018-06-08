using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour {
    public Text TimeText;
    private SpeedControl spdControl;
    private float second;
    private int minute;
	// Use this for initialization
	void Start () {
        spdControl = this.GetComponent<SpeedControl>();
        second = 60f;
        minute = 2;
	}
	
	// Update is called once per frame
	void Update () {
        second -= Time.deltaTime;
        if (second < 0)
        {
            if (minute == 0)
            {
                Time_Up();
            }
            else
            {
                minute--;
                second += 60;
            }
        }
        Time_Count();
	}
    void Time_Count()
    {
        if (second < 10)
        {
            this.TimeText.text = "Time=0" + minute + ":" + second;
        }
        else
        {
            this.TimeText.text = "Time=0" + minute + ":" + second;
        }
    }
    void Time_Up()
    {
        this.GetComponent<GameControl>().setState(GameControl.STATE.GAME_CLEAR);
    }
}
