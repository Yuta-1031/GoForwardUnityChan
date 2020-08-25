using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondUnityChan : MonoBehaviour {

	private float deadLine = -8;
	Animator animator;
	Rigidbody2D rigid2D;
	private float dump = 0.8f;
	float jumpVelocity = 20;
	private bool isGround;
	//GameObject ball;
	public GameObject ballPrefab;
	public GameObject bigBallPrefab;
	private float pos_x = 0;
	private float pos_y = 0;

	// Use this for initialization
	void Start()
	{
		this.animator = GetComponent<Animator>();
		this.rigid2D = GetComponent<Rigidbody2D>();

	}

	// Update is called once per frame
	void Update()
	{
		Vector2 unityChanpos = this.transform.position;
		pos_x = unityChanpos.x;
		pos_y = unityChanpos.y;


		if(unityChanpos.x < -3 && isGround)
        {
			this.transform.position = new Vector2(unityChanpos.x + 0.01f, pos_y);
        }
        if (Input.GetMouseButtonDown(1)) {
			if (GManager.instance.gaugeMax == 5)
            {
				GameObject bigBall = Instantiate(bigBallPrefab) as GameObject;
				bigBall.transform.position = new Vector2(pos_x + 2f, pos_y);
				GManager.instance.gaugeMax = 0;
            }
			GameObject ball = Instantiate(ballPrefab) as GameObject;
			ball.transform.position = new Vector2(pos_x + 1f, pos_y);
		}


		this.animator.SetFloat("Horizontal", 1);
		this.animator.SetBool("isGround", isGround);


		if (Input.GetMouseButtonDown(0) && isGround)
		{
			this.rigid2D.velocity = new Vector2(0, this.jumpVelocity);
		}


		if (Input.GetMouseButton(0) == false)
		{
			if (this.rigid2D.velocity.y > 0)
			{
				this.rigid2D.velocity *= this.dump;
			}
		}

		if (transform.position.x < this.deadLine)
		{
			Destroy(gameObject);
			GManager.instance.life -= 1;

			if(GManager.instance.life == 0)
            {
				GManager.instance.isGameOver = true;
				SceneManager.LoadScene("GameOverScene");
				//GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{

		this.animator.SetFloat("Horizontal", 1);
		isGround = true;
		this.animator.SetBool("isGround", isGround);

	}
	void OnCollisionExit2D(Collision2D collision)
	{
		isGround = false;
	}
}
