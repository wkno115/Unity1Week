﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        GameObject.Find("GameControler").GetComponent<GameControl>().setState(GameControl.STATE.GAME_TITLE);
    }
}
