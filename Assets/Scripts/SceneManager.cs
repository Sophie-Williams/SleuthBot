using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

    public int scene = 0; //determines functionality of accuse/playAlibi
    public int dialogueNumber = 0;
    public int sentenceCount = 0;

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
    public Vector3 sPosition1;
    public Vector3 oPosition2;
    public Vector3 wPosition2;
    public Vector3 oPosition3;
    public Vector3 wPosition3;
    public Vector3 oPosition4;
    public Vector3 wPosition4;
    public Vector3 oPosition5;


    private bool moveToPos2;
    private bool moveToPos3;
    private bool moveToPos4;
    private bool moveToPos5;
    private bool moveToPos6;
    private float posMoveTime = 20f;

    public Image silhouetteImage;
    public Sprite jenkinsSilhouette;
    public Sprite collinsSilhouette;
    public Sprite millerSilhouette;
    public Sprite whiteSilhouette;
    public Sprite smithSilhouette;
    public Sprite oneilSilhouette;

    public AudioSource voiceAudio;


    public bool challenging = false;

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
        showPositionMovements();
	}

    public void playSceneDialogue()
    {
        sentenceCount = 0;
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
        else if (scene == 2)
        {
            if (dialogueNumber == 0)
            {
                oCircle.color = new Color(1f, 1f, 1f, 0f);
                wCircle.color = new Color(1f, 1f, 1f, 0f);
                sCircle.color = new Color(1f, 1f, 1f, 0f);
                cCircle.color = new Color(1f, 1f, 1f, 0f);
            }

            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene2[dialogueNumber]);
            timeline.currentTime = 30;
            oCircle.color = new Color(1f, 1f, 1f, 1f);
            wCircle.color = new Color(1f, 1f, 1f, 1f);
            oCircle.rectTransform.anchoredPosition = oPosition1;
            wCircle.rectTransform.anchoredPosition = wPosition1;
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene2[dialogueNumber].name;
            nameField.color = currentColor;
        }
        else if (scene == 3)
        {
            if (dialogueNumber == 0)
            {
                oCircle.color = new Color(1f, 1f, 1f, 0f);
                wCircle.color = new Color(1f, 1f, 1f, 0f);
                sCircle.color = new Color(1f, 1f, 1f, 0f);
                cCircle.color = new Color(1f, 1f, 1f, 0f);
            }
            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene3[dialogueNumber]);
            sCircle.color = new Color(1f, 1f, 1f, 1f);
            sCircle.rectTransform.anchoredPosition = sPosition1;
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene3[dialogueNumber].name;
            nameField.color = currentColor;
        }
        else if (scene == 4)
        {
            if (dialogueNumber == 0)
            {
                oCircle.color = new Color(1f, 1f, 1f, 0f);
                wCircle.color = new Color(1f, 1f, 1f, 0f);
                sCircle.color = new Color(1f, 1f, 1f, 0f);
                cCircle.color = new Color(1f, 1f, 1f, 0f);
            }
            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene4[dialogueNumber]);
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene4[dialogueNumber].name;
            nameField.color = currentColor;
        }

        else if (scene == 5)
        {
            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene5[dialogueNumber]);
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene5[dialogueNumber].name;
            nameField.color = currentColor;
        }
        else if (scene == 6)
        {
            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene6[dialogueNumber]);
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene6[dialogueNumber].name;
            nameField.color = currentColor;
        }
        else if (scene == 7)
        {
            if(dialogueNumber == 4)
            {
                timeline.getItem(6);
            }
            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene7[dialogueNumber]);
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene7[dialogueNumber].name;
            nameField.color = currentColor;
        }
        else if (scene == 8)
        {
            if (dialogueNumber == 0)
            {
                oCircle.color = new Color(1f, 1f, 1f, 0f);
                wCircle.color = new Color(1f, 1f, 1f, 0f);
                sCircle.color = new Color(1f, 1f, 1f, 0f);
                cCircle.color = new Color(1f, 1f, 1f, 0f);
            }
            FindObjectOfType<DialogueManager>().startDialogue(sceneDialogues.scene8[dialogueNumber]);
            timeCorners.color = currentColor;
            nameField.text = sceneDialogues.scene8[dialogueNumber].name;
            nameField.color = currentColor;
        }
        if(nameField.text == "Collins")
        {
            silhouetteImage.sprite = collinsSilhouette;
            voiceAudio.pitch = 0.5f;
        }
        else if(nameField.text == "Jenkins")
        {
            silhouetteImage.sprite = jenkinsSilhouette;
            voiceAudio.pitch = 0.37f;
        }
        else if(nameField.text == "Miller")
        {
            silhouetteImage.sprite = millerSilhouette;
            voiceAudio.pitch = 0.6f;
        }
        else if(nameField.text == "Smith")
        {
            silhouetteImage.sprite = smithSilhouette;
            voiceAudio.pitch = 0.33f;
        }
        else if(nameField.text == "White")
        {
            silhouetteImage.sprite = whiteSilhouette;
            voiceAudio.pitch = 0.48f;
        }
        else if(nameField.text == "Brief")
        {
            silhouetteImage.sprite = oneilSilhouette;
            voiceAudio.pitch = 0.43f;
        }
        else
        {
            voiceAudio.pitch = 0.43f;
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
                if (dialogueNumber == 11)
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

                if (dialogueNumber == 1)
                {
                    timeline.getItem(1);
                }
                if (dialogueNumber == 2)
                {
                    timeline.currentTime = 30;
                    oCircle.color = new Color(1f, 1f, 1f, 1f);
                    wCircle.color = new Color(1f, 1f, 1f, 1f);
                    oCircle.rectTransform.anchoredPosition = oPosition1;
                    wCircle.rectTransform.anchoredPosition = wPosition1;
                }
                if (dialogueNumber == 3)
                {
                    moveToPos2 = true;
                    posMoveTime = 0;
                    timeline.getItem(2);
                }
                if (dialogueNumber == 4)
                {
                    sCircle.color = new Color(1f, 1f, 1f, 1f);
                    sCircle.rectTransform.anchoredPosition = sPosition1;
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
                    moveToPos4 = true;
                    posMoveTime = 0;
                }

            }
        }
        else if (scene == 2) //White Testimony
        {
            sentenceCount++;
            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if(dialogueNumber == 0)
            {

                if (sentenceCount == 1)
                {
                    timeline.currentTime = 40;
                    moveToPos2 = true;
                    posMoveTime = 0;
                }
                else if (sentenceCount == 5)
                {
                    timeline.currentTime = 60;
                    moveToPos4 = true;
                    oCircle.color = new Color(1f, 1f, 1f, 0f);
                    posMoveTime = 0;
                }
            }
            if (currentText == null)
            {
                if (dialogueNumber < 1)
                {
                    dialogueNumber++;
                }
                else
                {
                    scene = 1;
                    dialogueNumber = 9;
                    playSceneDialogue();
                }
            }
        }
        else if (scene == 3) //Smith Testimony
        {
            sentenceCount++;
            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if (dialogueNumber == 0)
            {

                if (sentenceCount == 4)
                {
                    timeline.currentTime = 60;
                    oCircle.color = new Color(1f, 1f, 1f, 1f);
                    wCircle.color = new Color(1f, 1f, 1f, 1f);
                    oCircle.rectTransform.anchoredPosition = oPosition3;
                    wCircle.rectTransform.anchoredPosition = wPosition3;
                }

            }
            if (currentText == null)
            {
                if (dialogueNumber < 1)
                {
                    dialogueNumber++;
                }
                else
                {
                    scene = 1;
                    dialogueNumber = 9;
                    playSceneDialogue();
                }
            }
        }
        else if (scene == 4) //Crass Testimony
        {
            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if (currentText == null)
            {
                if (dialogueNumber < 1)
                {
                    dialogueNumber++;
                }
                else
                {
                    scene = 1;
                    dialogueNumber = 9;
                    playSceneDialogue();
                }
            }
        }
        else if (scene == 5) //Oneil profile
        {
            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if (currentText == null)
            {
                if (dialogueNumber < 1)
                {
                    dialogueNumber++;
                }
                else
                {
                    scene = 1;
                    dialogueNumber = 9;
                    playSceneDialogue();
                }
            }
        }
        else if (scene == 6) //Camera recording
        {
            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if (currentText == null)
            {
                if (dialogueNumber < 1)
                {
                    dialogueNumber++;
                }
                else
                {
                    scene = 1;
                    dialogueNumber = 9;
                    playSceneDialogue();
                }
            }
        }
        else if (scene == 7) //Challenge Smith Statement
        {
            sentenceCount++;
            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if(dialogueNumber == 0 && sentenceCount == 1)
            {
                wCircle.color = new Color(1f, 1f, 1f, 0f);
                oCircle.color = new Color(1f, 1f, 1f, 1f);
                oCircle.rectTransform.anchoredPosition = oPosition3;

            }
            if (currentText == null)
            {
                if (dialogueNumber < 5)
                {
                    dialogueNumber++;
                }
                else
                {
                    scene = 1;
                    dialogueNumber = 9;
                    playSceneDialogue();
                }
            }
        }
        else if (scene == 8) //Jenkins Tape
        {
            sentenceCount++;
            currentText = FindObjectOfType<DialogueManager>().displayNextSentence();
            if(dialogueNumber == 0)
            {
                if(sentenceCount == 2)
                {
                    timeline.currentTime = 35;
                    wCircle.color = new Color(1f, 1f, 1f, 1f);
                    oCircle.color = new Color(1f, 1f, 1f, 1f);
                    wCircle.rectTransform.anchoredPosition = wPosition3;
                    oCircle.rectTransform.anchoredPosition = oPosition3;
                }
                else if(sentenceCount == 3)
                {
                    sCircle.color = new Color(1f, 1f, 1f, 1f);
                    sCircle.rectTransform.anchoredPosition = sPosition1;
                }
                else if(sentenceCount == 4)
                {
                    posMoveTime = 0;
                    moveToPos6 = true;
                }
            }
            if (currentText == null)
            {
                if (dialogueNumber < 1)
                {
                    dialogueNumber++;
                }
                else
                {
                    scene = 1;
                    dialogueNumber = 9;
                    playSceneDialogue();
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

    void showPositionMovements()
    {
        posMoveTime += Time.deltaTime;
        if(moveToPos2)
        {
            oCircle.rectTransform.anchoredPosition = Vector3.Lerp(oPosition1, oPosition2, posMoveTime);
            wCircle.rectTransform.anchoredPosition = Vector3.Lerp(wPosition1, wPosition2, posMoveTime);
            if (posMoveTime > 1)
            {
                moveToPos2 = false;
                moveToPos3 = true;
                posMoveTime = 0;
            }

        }
        if (moveToPos3)
        {
            oCircle.rectTransform.anchoredPosition = Vector3.Lerp(oPosition2, oPosition3, posMoveTime);
            wCircle.rectTransform.anchoredPosition = Vector3.Lerp(wPosition2, wPosition3, posMoveTime);

            if (posMoveTime > 1)
            {
                moveToPos3 = false;
            }
        }
        if (moveToPos4)
        {
            oCircle.rectTransform.anchoredPosition = Vector3.Lerp(oPosition3, oPosition4, posMoveTime);
            wCircle.rectTransform.anchoredPosition = Vector3.Lerp(wPosition3, wPosition2, posMoveTime);
            if (posMoveTime > 1)
            {
                moveToPos4 = false;
                moveToPos5 = true;
                posMoveTime = 0;
            }
        }
        if (moveToPos5)
        {
            wCircle.rectTransform.anchoredPosition = Vector3.Lerp(wPosition2, wPosition1, posMoveTime);
            if (posMoveTime > 1)
            {
                moveToPos5 = false;
            }

        }
        if (moveToPos6)
        {
            oCircle.rectTransform.anchoredPosition = Vector3.Lerp(oPosition3, oPosition5, posMoveTime);
            wCircle.rectTransform.anchoredPosition = Vector3.Lerp(wPosition3, wPosition2, posMoveTime);
            if (posMoveTime > 1)
            {
                moveToPos6 = false;
                moveToPos5 = true;
                posMoveTime = 0;
            }
        }

    }
}
