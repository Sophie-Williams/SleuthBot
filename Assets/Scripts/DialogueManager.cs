using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences;
    public Text dialogueText;
    // Start is called before the first frame update
    void Start()
    {
        //dialogueText = GameObject.Find("Dialogue").GetComponent<Text>();
    }

    public void startDialogue(Dialogue dialogue)
    {
        dialogueText.color = dialogue.dialogueColor;
        GameObject.Find("SceneManager").GetComponent<SceneManager>().currentColor = dialogue.dialogueColor;
        if (sentences == null)
        {
            sentences = new Queue<string>();

        }
        else
        {
            sentences.Clear();
        }
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        GameObject.Find("SceneManager").GetComponent<SceneManager>().currentText = sentences.Peek();

        displayNextSentence();
    }

    public string displayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return null;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        return sentence;

    }

    IEnumerator TypeSentence(string typeText)
    {
        dialogueText.text = "";
        foreach (char letter in typeText.ToCharArray())
        {
            GetComponent<AudioSource>().Play();
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
    }
}
