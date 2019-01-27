using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemVisual : MonoBehaviour {

    public ItemFunctionality itemFunctionality;
    public Item currentItem;
    public SceneManager sceneManager;
    private Color systemColor;
    private EventTrigger.Entry mouseEntry;
    private EventTrigger.Entry mouseLeave;
    private EventTrigger.Entry mouseClick;
    // Use this for initialization
    void Start () {
        systemColor = new Color(57f / 255f, 140f / 255f, 53f / 255f, 1f);
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManager>();
        itemFunctionality = GameObject.Find("SceneManager").GetComponent<ItemFunctionality>();
    }
	
	// Update is called once per frame
	void Update () {
        checkAction();
	}

    void checkAction()
    {
        
    }

    void mouseEnter(PointerEventData data)
    {
        Text dialogueText = GameObject.Find("Dialogue").GetComponent<Text>();
        dialogueText.color = systemColor;
        dialogueText.text = currentItem.itemDescription;
        sceneManager.activeMouse = false;
    }

    void mouseExit(PointerEventData data)
    {
        Text dialogueText = GameObject.Find("Dialogue").GetComponent<Text>();
        dialogueText.color = sceneManager.currentColor;
        dialogueText.text = sceneManager.currentText;
        sceneManager.activeMouse = true;
    }

    void mouseDown(PointerEventData data)
    {
        itemFunctionality.activate(currentItem.itemName);
    }


    public void setItem(Item item)
    {
        if (item.itemName == null)
        {
            currentItem = item;
            itemFunctionality.setSprite(item.itemName, GetComponent<Image>());
            EventTrigger trigger = GetComponent<EventTrigger>();
            mouseEntry = new EventTrigger.Entry();
            mouseEntry.eventID = EventTriggerType.PointerEnter;
            mouseEntry.callback.AddListener((data) => { });
            trigger.triggers.Add(mouseEntry);
            mouseLeave = new EventTrigger.Entry();
            mouseLeave.eventID = EventTriggerType.PointerExit;
            mouseLeave.callback.AddListener((data) => { });
            trigger.triggers.Add(mouseLeave);
            mouseClick = new EventTrigger.Entry();
            mouseClick.eventID = EventTriggerType.PointerDown;
            mouseClick.callback.AddListener((data) => { });
            trigger.triggers.Add(mouseClick);
            return;
        }
        else
        {
            currentItem = item;
            EventTrigger trigger = GetComponent<EventTrigger>();
            mouseEntry = new EventTrigger.Entry();
            mouseEntry.eventID = EventTriggerType.PointerEnter;
            mouseEntry.callback.AddListener((data) => { mouseEnter((PointerEventData)data); });
            trigger.triggers.Add(mouseEntry);
            mouseLeave = new EventTrigger.Entry();
            mouseLeave.eventID = EventTriggerType.PointerExit;
            mouseLeave.callback.AddListener((data) => { mouseExit((PointerEventData)data); });
            trigger.triggers.Add(mouseLeave);
            mouseClick = new EventTrigger.Entry();
            mouseClick.eventID = EventTriggerType.PointerDown;
            mouseClick.callback.AddListener((data) => { mouseDown((PointerEventData)data); });
            trigger.triggers.Add(mouseClick);
            Debug.Log("Setting item in itemVisual: " + item.itemName);
            itemFunctionality.setSprite(item.itemName, GetComponent<Image>());
        }
    }
}
