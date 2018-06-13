using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpeedEffect : MonoBehaviour {
    public GameObject speedEffect;
    private List<GameObject> effects;
    private float rand;
	// Use this for initialization
	void Start () {
        effects = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        float rand = Random.Range(-4, 7);
        Vector3 y = Vector3.up * rand;
        rand=Mathf.Round(rand);
        if (rand !=1) 
        {
            effects.Add(Instantiate(speedEffect,this.transform.position+y, Quaternion.identity));
        }
        SpeedForce();
	}
    void SpeedForce()
    {
        float vx=0.1f;
        for(int i = 0; i < this.effects.Count; i++)
        {
            Vector2 v = effects[i].transform.position;
            v.x -= vx ;
            effects[i].transform.position = v;
        }
    }
}
