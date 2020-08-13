using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour {
	public GameObject ballPrefab;
	GameObject ball;
	public Transform m_muzzle;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject ball = Instantiate(ballPrefab, m_muzzle.position, Quaternion.identity) as GameObject;
		}
	}
	

}
