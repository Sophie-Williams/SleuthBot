using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemFunctionality : MonoBehaviour {

    public Sprite folderSprite;
    public Sprite profileSprite;
    public Sprite cameraSprite;
    public Sprite whiteTape;
    public Sprite smithTape;
    public Sprite crassTape;

    /** 
     * Defines the functionality of all items in the game.
     * Makes heavy usage of the SceneManager's scene and Dialogue variables to know what we're doing.
     **/
    public void activate(string itemName)
    {
        if(itemName == "H-9303 Police Report")
        {
            Debug.Log("Clicked on Case Files");
            FindObjectOfType<SceneManager>().scene = 1;
            FindObjectOfType<SceneManager>().dialogueNumber = 0;
            FindObjectOfType<SceneManager>().playSceneDialogue();
            FindObjectOfType<Timeline>().resetInventory();

        }
    }

    public void setSprite(string itemName, Image itemImage )
    {
        if(itemName == null)
        {
            itemImage.sprite = null;
        }
        else if (itemName == "H-9303 Police Report")
        {
            itemImage.sprite = folderSprite;
        }
        else if (itemName == "Oneil Profile")
        {
            itemImage.sprite = profileSprite;
        }
        else if (itemName == "Camera Recording")
        {
            itemImage.sprite = cameraSprite;
        }
        else if (itemName == "White Tape")
        {
            itemImage.sprite = whiteTape;
        }
        else if (itemName == "Smith Tape")
        {
            itemImage.sprite = smithTape;
        }
        else if (itemName == "Crass Tape")
        {
            itemImage.sprite = crassTape;
        }
    }
}
