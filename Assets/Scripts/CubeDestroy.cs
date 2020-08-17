﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroy : MonoBehaviour {
	public GameObject effectPrefab;

	// Use this for initialization
	void Start()
	{
		
	}

    void Update()
    {
	
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Ball"))
		{
			GameObject go = Instantiate(effectPrefab) as GameObject;
			go.transform.position = this.transform.position;


			Destroy(this.gameObject);
		}
	}

	
}


