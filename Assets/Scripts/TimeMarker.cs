using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMarker : MonoBehaviour {
    public Image timeMarker;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public Timeline timeline;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeMarker.rectTransform.anchoredPosition = Vector3.Lerp(startPosition, endPosition, timeline.getCurrentTime() / 100);
	}
}
