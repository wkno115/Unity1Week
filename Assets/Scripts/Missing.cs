using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missing : MonoBehaviour
{
    public GameControl gmControl;
    public Runner runner;
    private Create_Obstacles createObs;
    private GameObject gmObj;
    // Use this for initialization
    void Start()
    {
        createObs = GetComponent<Create_Obstacles>();
    }

    // Update is called once per frame
    void Update()
    {
        gmObj = createObs.getCurrentObject();
        if (gmObj.GetComponent<IsCollision>().getTouch())
        {
            switch (createObs.getType()) {
                case 's':
                    if (runner.getPose()==Runner.POSE.SLIDING)
                    {
                    }
                    else
                    {
                        Debug.Log(runner.getPose());
                        Miss();
                    }
                    break;
                default:
                    Miss();
                    break;
            }
        }

    }
    public void Miss()
    {
        gmControl.setState(GameControl.STATE.GAME_OVER);
    }
}
