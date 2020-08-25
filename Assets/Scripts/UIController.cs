using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
	private GameObject gameOverText;
	private GameObject runLengthText;
	private GameObject lifeText;
	private int lifeNum;
	public float run;
	private float speed = 0.03f;
	//public bool isGameOver = false;

	// Use this for initialization
	void Start()
	{
		GManager.instance.isGameOver = false;
		GManager.instance.life = 3;
		this.run = GManager.instance.runLength;
		run = 0f;
		this.gameOverText = GameObject.Find("GameOver");
		this.runLengthText = GameObject.Find("RunLength");
		this.lifeText = GameObject.Find("Life");
	
	}
	
	// Update is called once per frame
	void Update () {

		this.lifeText.GetComponent<Text>().text = "Life: " + GManager.instance.life + " ";
		this.runLengthText.GetComponent<Text>().text = "Distance: " + run + " ";
		
		if (GManager.instance.isGameOver == false)
        {
			run += this.speed;
			this.runLengthText.GetComponent<Text>().text = "Distance: " + run.ToString("F2") + "m" + " ";
        }
		GManager.instance.runLength = run;

        

		/*if(this.isGameOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
				SceneManager.LoadScene("GameScene");
            }
        }*/
	}
	/*public void GameOver()
    {
		this.gameOverText.GetComponent<Text>().text = "GameOver";
		this.isGameOver = true;
    }*/
}
