using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Obstacles : MonoBehaviour {
    int rand;
    public int min, max;
    public GameObject j_obj, s_obj;
    public SpeedControl gameControler;
    GameObject currentObj;
    char type;

    // Use this for initialization
    void Start() {
        rand = Random.Range(min, max);
        currentObj = Instantiate(j_obj, this.transform.position, Quaternion.identity);
        type = 'j';
        Adjust(ref currentObj, type);
    }

    // Update is called once per frame
    void Update() {
        if (currentObj.transform.position.x < -10)
        {
            switch (rand)
            {
                case 0:
                    Destroy(currentObj);
                    currentObj = Instantiate(j_obj, this.transform.position, Quaternion.identity);
                    type = 'j';
                    break;
                case 1:
                    Destroy(currentObj);
                    currentObj = Instantiate(s_obj, this.transform.position, Quaternion.identity);
                    type = 's';
                    break;
            }
            Adjust(ref currentObj, type);
            rand = Random.Range(min, max);
        }
        else
        {
            Vector2 v = currentObj.transform.localPosition;
            v.x -= gameControler.getSpeed();
            currentObj.transform.localPosition = v;
        }
    }

    void Adjust(ref GameObject obj, char type)
    {
        Vector2 s = obj.transform.localScale;
        s.x *= 3;
        s.y *= 6;
        obj.transform.localScale = s;
        Vector2 v = currentObj.transform.localPosition;
        switch (type)
        {
            case 'j':
                v.y += 0f;
                currentObj.transform.localPosition = v;
                break;
            case 's':
                v.y += 1.5f;
                currentObj.transform.localPosition = v;
                break;



        }
    }
    public GameObject getCurrentObject()
    {
        return currentObj;
    }
    public char getType()
    { 
        return type;
    }
}
