﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public static int MAX_TEXT_LENGTH = 200;
    public string name;
    public Color dialogueColor;
    public string[] sentences;

    public Dialogue(string[] sentences)
    {
        this.sentences = sentences;
    }

    public Dialogue(Color textColor, string[] sentences)
    {
        dialogueColor = textColor;
        this.sentences = sentences;
    }

    public Dialogue(string name, Color textColor, string[] sentences)
    {
        this.name = name;
        dialogueColor = textColor;
        this.sentences = sentences;
    }
}
