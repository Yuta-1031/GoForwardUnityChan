using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
	//public GameObject unityChan2;
	public Transform spawnPoint;
	bool coll = false;
	private GameObject UnityChan;

	// Use this for initialization
	void Start () {

		this.UnityChan = Instantiate(GManager.instance.unityChan, spawnPoint.position, Quaternion.identity) as GameObject;

	}
	
	// Update is called once per frame
	void Update () {

		//Vector2 unityChanPosition = UnityChan.transform.position;
		//float x = unityChanPosition.x;

		if(GManager.instance.life == 2)
        {
            if (!coll) {
				coll = true;
				GameObject UnityChan2 = Instantiate(GManager.instance.unityChan, spawnPoint.position, Quaternion.identity) as GameObject;
			}
		}

		if (GManager.instance.life == 1)
		{
			if (coll)
			{
				coll = false;
				GameObject UnityChan3 = Instantiate(GManager.instance.unityChan, spawnPoint.position, Quaternion.identity) as GameObject;
			}
		}
	}
}
