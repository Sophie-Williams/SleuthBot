using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChallengeActivate : MonoBehaviour {


    public SceneManager sceneManager;
    public Image cancelImage;
    public Text cancelText;


    // Use this for initialization
    void Start () {
        sceneManager = FindObjectOfType<SceneManager>();
        addTriggers();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void mouseEnter(PointerEventData data)
    {

        sceneManager.activeMouse = false;
    }

    void mouseExit(PointerEventData data)
    {
        sceneManager.activeMouse = true;
    }

    private void clickedChallenge(PointerEventData data)
    {
        sceneManager.challenging = true;
        cancelImage.color = new Color(66f/255, 65f/255, 66f/255f, 1f);
        cancelText.color = Color.red;
        Debug.Log("Challenging!");

    }

    private void addTriggers()
    {
        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry mouseEntry = new EventTrigger.Entry();
        mouseEntry.eventID = EventTriggerType.PointerEnter;
        mouseEntry.callback.AddListener((data) => { mouseEnter((PointerEventData)data); });
        trigger.triggers.Add(mouseEntry);
        EventTrigger.Entry mouseLeave = new EventTrigger.Entry();
        mouseLeave.eventID = EventTriggerType.PointerExit;
        mouseLeave.callback.AddListener((data) => { mouseExit((PointerEventData)data); });
        trigger.triggers.Add(mouseLeave);
        EventTrigger.Entry mouseClick = new EventTrigger.Entry();
        mouseClick.eventID = EventTriggerType.PointerDown;
        mouseClick.callback.AddListener((data) => { clickedChallenge((PointerEventData)data); });
        trigger.triggers.Add(mouseClick);
    }
}
