using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCount : MonoBehaviour {
    private float distance;
    public Text DistanceText;
	// Use this for initialization
	void Start () {
        distance = 0;
	}
	
	// Update is called once per frame
	void Update () {
        PlusDistance();
        Distance_Count();
	}
    void PlusDistance()
    {
        if (this.GetComponent<SpeedControl>().PoseCheck()) {
            distance += (Time.deltaTime*0.5f);
        }
        else
        {
            distance += Time.deltaTime;
        }
    }
    void Distance_Count()
    {
        this.DistanceText.text = "走行距離:" + (Mathf.Round(distance*10)/10)+"m";
    }
}
