using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeline : MonoBehaviour {

    public GameObject[] itemVisualArray;


    int count = 0;
    bool timeRunning; //whether basic play functionality is running.
    int timelineIndex; //binary mask determining which timeline is being used.
    public float currentTime; //value between 0-100 representing current time of
                              //the scene.
    
    List<Item> inventory; 
	// Use this for initialization
	void Start () {
        inventory = new List<Item>();
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
        if (timeRunning && currentTime < 100)
        {
            currentTime += Time.deltaTime * 2;
        }
    }

    public void getItem(int itemIndex)
    {
        if (itemIndex == 0)
        {
            Debug.Log("Getting police report");
            Item report0 = new Item("H-9303 Police Report", "Report on the H-9303 incident. Click to investigate this case");
            inventory.Add(report0);
            itemVisualArray[count].GetComponent<ItemVisual>().setItem(report0);
            count++;
        }
        if (itemIndex == 1)
        {
            Debug.Log("Getting Oneil profile");
            Item oneilProfile = new Item("Oneil Profile", 
                "Information related to the victim, Haley O'Neil");
            inventory.Add(oneilProfile);
            itemVisualArray[count].GetComponent<ItemVisual>().setItem(oneilProfile);
            count++;
        }
        if (itemIndex == 2)
        {
            Debug.Log("Getting Camera Recording");
            Item cameraRecord = new Item("Camera Recording",
                "Recordings captured by the apartment complex's entrance camera");
            inventory.Add(cameraRecord);
            itemVisualArray[count].GetComponent<ItemVisual>().setItem(cameraRecord);
            count++;
        }
        if (itemIndex == 3)
        {
            Debug.Log("Getting Smith Tape");
            Item smithTape = new Item("Smith Tape",
                "Statements given by Derrick Smith. Click to review full transcript");
            inventory.Add(smithTape);
            itemVisualArray[count].GetComponent<ItemVisual>().setItem(smithTape);
            count++;
        }
        if (itemIndex == 4)
        {
            Debug.Log("Getting White Tape");
            Item whiteTape = new Item("White Tape",
                "Statements given by Drew White. Click to review full transcript");
            inventory.Add(whiteTape);
            itemVisualArray[count].GetComponent<ItemVisual>().setItem(whiteTape);
            count++;
        }
        if(itemIndex == 6)
        {
            Debug.Log("Getting Jenkins Tape");
            Item jenkinsTape = new Item("Jenkins Tape",
                "Explanation given by Detective Jenkins. Click to replay.");
            inventory.Add(jenkinsTape);
            itemVisualArray[count].GetComponent<ItemVisual>().setItem(jenkinsTape);
            count++;
        }
    }

    public void resetInventory()
    {
        count = 0;
        foreach (GameObject g in itemVisualArray)
        {
            Item nullObj = new Item(null, null);
            itemVisualArray[0].GetComponent<ItemVisual>().setItem(nullObj);
        }
    }
}
