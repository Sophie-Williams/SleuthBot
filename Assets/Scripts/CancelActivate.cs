using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CancelActivate : MonoBehaviour {


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
        sceneManager.challenging = false;
        cancelImage.color = new Color(1f, 1f, 1f, 0f);
        cancelText.color = new Color(1f, 1f, 1f, 0f);

        Debug.Log("Cancelled Challenge");
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
