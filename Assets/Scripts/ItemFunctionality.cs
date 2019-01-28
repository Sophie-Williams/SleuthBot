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
    public Sprite jenkinsTape;

    public Image cancelImage;
    public Text cancelText;

    /** 
     * Defines the functionality of all items in the game.
     * Makes heavy usage of the SceneManager's scene and Dialogue variables to know what we're doing.
     **/
    public void activate(string itemName)
    {
        if (!FindObjectOfType<SceneManager>().challenging) {
            if (itemName == "H-9303 Police Report")
            {
                Debug.Log("Clicked on Case Files");
                FindObjectOfType<SceneManager>().scene = 1;
                FindObjectOfType<SceneManager>().dialogueNumber = 0;
                FindObjectOfType<SceneManager>().playSceneDialogue();
                FindObjectOfType<Timeline>().resetInventory();

            }
            else if (itemName == "White Tape")
            {
                Debug.Log("Clicked on White Tape");
                FindObjectOfType<SceneManager>().scene = 2;
                FindObjectOfType<SceneManager>().dialogueNumber = 0;
                FindObjectOfType<SceneManager>().playSceneDialogue();
            }
            else if (itemName == "Smith Tape")
            {
                Debug.Log("Clicked on Smith Tape");
                FindObjectOfType<SceneManager>().scene = 3;
                FindObjectOfType<SceneManager>().dialogueNumber = 0;
                FindObjectOfType<SceneManager>().playSceneDialogue();
            }
            else if (itemName == "Crass Tape")
            {
                Debug.Log("Clicked on Crass Tape");
                FindObjectOfType<SceneManager>().scene = 4;
                FindObjectOfType<SceneManager>().dialogueNumber = 0;
                FindObjectOfType<SceneManager>().playSceneDialogue();
            }
            else if (itemName == "Oneil Profile")
            {
                Debug.Log("Clicked on Oneil Profile");
                FindObjectOfType<SceneManager>().scene = 5;
                FindObjectOfType<SceneManager>().dialogueNumber = 0;
                FindObjectOfType<SceneManager>().playSceneDialogue();
            }
            else if (itemName == "Camera Recording")
            {
                Debug.Log("Clicked on Camera Recording");
                FindObjectOfType<SceneManager>().scene = 6;
                FindObjectOfType<SceneManager>().dialogueNumber = 0;
                FindObjectOfType<SceneManager>().playSceneDialogue();
            }
            else if (itemName == "Jenkins Tape")
            {
                Debug.Log("Clicked on Jenkins Tape");
                FindObjectOfType<SceneManager>().scene = 8;
                FindObjectOfType<SceneManager>().dialogueNumber = 0;
                FindObjectOfType<SceneManager>().playSceneDialogue();
            }
        }
    }

    public void challenge(string itemName)
    {

        if (FindObjectOfType<SceneManager>().challenging)
        {
            if (itemName == "H-9303 Police Report")
            {
                Debug.Log("Challenged with Police Report");

            }
            else if (itemName == "White Tape")
            {
                Debug.Log("Challenged with White Tape");
            }
            else if (itemName == "Smith Tape")
            {
                Debug.Log("Challenged with Smith Tape");
            }
            else if (itemName == "Crass Tape")
            {
                Debug.Log("Challenged with Crass Tape");
            }
            else if (itemName == "Oneil Profile")
            {
                Debug.Log("Challenged with Oneil Tape");
            }
            else if (itemName == "Camera Recording")
            {
                GetComponent<AudioSource>().Play();
                SceneManager sceneManager = FindObjectOfType<SceneManager>();
                Debug.Log("Challenged with Camera Recording");
                if(sceneManager.scene == 3 && sceneManager.dialogueNumber == 0 &&
                   (sceneManager.sentenceCount == 3 || sceneManager.sentenceCount == 4) )
                {
                    FindObjectOfType<SceneManager>().scene = 7;
                    FindObjectOfType<SceneManager>().dialogueNumber = 0;
                    FindObjectOfType<SceneManager>().playSceneDialogue();
                }
            }
            else if (itemName == "Jenkins Tape")
            {
                Debug.Log("Challenged with Jenkins Tape");
            }
            FindObjectOfType<SceneManager>().challenging = false;
            cancelImage.color = new Color(1f, 1f, 1f, 0f);
            cancelText.color = new Color(1f, 1f, 1f, 0f);
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
        else if (itemName == "Jenkins Tape")
        {
            itemImage.sprite = jenkinsTape;
        }
    }
}
