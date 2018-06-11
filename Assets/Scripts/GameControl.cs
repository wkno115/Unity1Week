using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {
    public enum STATE
    {
        GAME_TITLE,
        GAME_START,
        GAME_OPTION,
        GAME_OVER,
        GAME_CLEAR,
    }
    private STATE G_Status;
    public Canvas gameover;
    public Canvas gameclear;
    public Runner runner;
	// Use this for initialization
	void Start () {
        G_Status = STATE.GAME_START;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void ChangeScene()
    {
        switch (G_Status) {
            case STATE.GAME_START:
                Time.timeScale = 1f;
                SceneManager.LoadScene("Main");
                break;
            case STATE.GAME_OVER:
                Debug.Log("GAMEOVER");
                GameOver();
                break;
            case STATE.GAME_CLEAR:
                GameClear();
                SceneManager.LoadScene("GameClear");
                break;
            case STATE.GAME_TITLE:
                SceneManager.LoadScene("Title");
                break;
            default:
                Debug.Log("変化なし");
                break;
        }
    }
    public void setState(STATE state)
    {
        G_Status = state;
        ChangeScene();
    }
    public void GameOver()
    {
        gameover.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0f;
    }
    public void GameClear()
    {
        gameclear.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0f;
    }
}
