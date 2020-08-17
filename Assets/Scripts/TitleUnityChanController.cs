using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleUnityChanController : MonoBehaviour {

	Animator animator;
	Rigidbody2D rigid2D;
	private bool isGround;


	// Use this for initialization
	void Start()
	{

		this.animator = GetComponent<Animator>();
		this.rigid2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		this.animator.SetFloat("Horizontal", 1);
		this.animator.SetBool("isGround", isGround);

	}
	void OnCollisionEnter2D(Collision2D collision)
	{

		this.animator.SetFloat("Horizontal", 1);
		isGround = true;
		this.animator.SetBool("isGround", isGround);

	}
	
}
