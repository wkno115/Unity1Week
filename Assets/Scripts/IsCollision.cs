using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCollision : MonoBehaviour {
    private bool touch;
	// Use this for initialization
	void Start () {
        touch = false;
	}
	
	// Update is called once per frame
	void Update () {
        touch = false;
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            touch = true;
        }
    }
    public bool getTouch()
    {
        return touch;
    }
}
