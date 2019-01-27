using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

    public int scene = 0; //determines functionality of accuse/playAlibi
    public int dialogueNumber = 0;
    SceneDialogues sceneDialogues;
    public string currentText;
    public Color currentColor;
    public Image timeCorners;
    public Text nameField;
    public bool activeMouse = true;
    Timeline timeline;

    private bool showMap = false;
    private Image currMapImage;
    public Text mapNoData;
    public Image mapImage0;
    private float transitionTime;

    public Image oCircle;
    public Image wCircle;
    public Image sCircle;
    public Image cCircle;

    public Vector3 oPosition1;
    public Vector3 wPosition1;

    // Use this for initialization
    void Start () {
        timeline = FindObjectOfType<Timeline>();
        sceneDialogues = new SceneDialogues();
        playSceneDialogue();
	}
	
	// Update is called once per frame
	void Update () {
        checkForInput();
        showMapTransition();
	}

    public void playSceneDialogue()
    {
        if (scene == 0)
        {
            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene0[dialogueNumber]);
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene0[dialogueNumber].name;
            nameField.color = currentColor;
        }
        else if (scene == 1)
        {
            if (dialogueNumber == 0)
            {
                oCircle.color = new Color(1f, 1f, 1f, 0f);
                wCircle.color = new Color(1f, 1f, 1f, 0f);
                sCircle.color = new Color(1f, 1f, 1f, 0f);
                cCircle.color = new Color(1f, 1f, 1f, 0f);
            }
            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene1[dialogueNumber]);
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene1[dialogueNumber].name;
            nameField.color = currentColor;
        }
    }

    void checkForInput()
    {
        if(Input.GetMouseButtonDown(0) && activeMouse) {
            //left mouse button pressed, advance dialogue.
            advanceDialogue();
        }
    }

    void advanceDialogue()
    {
        if (scene == 0)
        {

            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if (currentText == null)
            {
                if (dialogueNumber < 16)
                {
                    dialogueNumber++;
                }
                if(dialogueNumber == 11)
                {
                    GetComponent<AudioSource>().Play();
                    transitionTime = 0f;
                    Debug.Log("Showing Map");
                    showMap = true;
                    currMapImage = mapImage0;

                }
                else if (dialogueNumber == 15)
                {
                    Debug.Log("Trying to get Police Report");
                    timeline.getItem(0);
                }
            }
        }
        else if (scene == 1)
        {

            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if (currentText == null)
            {
                if (dialogueNumber < 9)
                {
                    dialogueNumber++;
                }
                
                if(dialogueNumber == 1)
                {
                    timeline.getItem(1);
                }
                if (dialogueNumber == 2)
                {
                    timeline.currentTime = 30;
                    oCircle.color = new Color(1f, 1f, 1f, 1f);
                    wCircle.color = new Color(1f, 1f, 1f, 1f);
                    oCircle.rectTransform.position = oPosition1;
                    wCircle.rectTransform.position = wPosition1;
                }
                if (dialogueNumber == 3)
                {
                    timeline.getItem(2);
                }
                if (dialogueNumber == 4)
                {
                    timeline.currentTime = 50;
                }
                if (dialogueNumber == 5)
                {
                    timeline.getItem(3);
                }
                if (dialogueNumber == 7)
                {
                    timeline.getItem(4);
                }
                if (dialogueNumber == 8)
                {
                    timeline.currentTime = 90;
                }

            }
        }
        if (currentText == null)
        {
            playSceneDialogue();
        }
    }

    void showMapTransition()
    {
        if (showMap)
        {
            transitionTime += Time.deltaTime;
            mapNoData.color = new Color(57f / 255f, 140f / 255f, 53f / 255f, Mathf.Lerp(1f, 0, transitionTime));
            currMapImage.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, transitionTime));
        }
    }
}
