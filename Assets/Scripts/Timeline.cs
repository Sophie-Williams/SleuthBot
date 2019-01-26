using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeline : MonoBehaviour {
    public struct Item
    {
        string itemName;
        string itemDescription;
    }
    bool timeRunning; //whether basic play functionality is running.
    int timelineIndex; //binary mask determining which timeline is being used.
    public float currentTime; //value between 0-100 representing current time of
                              //the scene.
    
    List<Item> inventory; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        advanceTime();
	}

    public float getCurrentTime()
    {
        return currentTime;
    }

    private void advanceTime()
    {
        currentTime += Time.deltaTime * 10;
    }
}
