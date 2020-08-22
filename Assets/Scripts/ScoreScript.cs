﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text scoreText;

	// Use this for initialization
	void Start () {
		Text score = scoreText.GetComponent<Text>();
		score.text = "Score: " + GManager.instance.runLength.ToString("F2") + "m";
	}
	
	// Update is called once per frame
	void Update () {
	}
}
