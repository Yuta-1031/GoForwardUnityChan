using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
	public GameObject unityChan2;
	public Transform spawnPoint;
	bool coll = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector2 unityChanPosition = GameObject.Find("UnityChan2D").transform.position;
		float x = unityChanPosition.x;


		if(x < -9)
        {
			if (!coll)
			{
				coll = true;
				GameObject UnityChan2 = Instantiate(unityChan2, spawnPoint.position, Quaternion.identity) as GameObject;
			}
        }
	}
}
