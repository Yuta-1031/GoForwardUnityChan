﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	private bool firstPush = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PressStart()
    {
       if (!firstPush)
       {
			firstPush = true;
			SceneManager.LoadScene("GameScene");
        }
    }
}
