using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public GameObject scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find("Score");
	}
	
	// Update is called once per frame
	void Update () {
		Text score = scoreText.GetComponent<Text>();
		score.text = "Score: " + GManager.instance.score;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if(collision.gameObject.tag == "Ball")
        {
			GManager.instance.score += 10;
			Debug.Log(GManager.instance.score);
        }
    }
}
