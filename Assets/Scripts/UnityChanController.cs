﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour {
	Animator animator;
	Rigidbody2D rigid2D;
	private float groundLevel = -3.0f;
	private float dump = 0.8f;
	float jumpVelocity = 20;
	private float deadLine = -9;

	// Use this for initialization
	void Start () {
		
		this.animator = GetComponent<Animator>();
		this.rigid2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		this.animator.SetFloat("Horizontal", 1);
		bool isGorund = (transform.position.y > this.groundLevel) ? false : true;
		this.animator.SetBool("isGround", isGorund);

		GetComponent<AudioSource>().volume = (isGorund) ? 1 : 0;

		if(Input.GetMouseButtonDown(0) && isGorund)
        {
			this.rigid2D.velocity = new Vector2(0, this.jumpVelocity);
        }

		if(Input.GetMouseButton(0) == false)
        {
			if(this.rigid2D.velocity.y > 0)
            {
				this.rigid2D.velocity *= this.dump;
            }
        }

		if(transform.position.x < this.deadLine)
        {
			GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
			Destroy(gameObject);
        }
	}
}