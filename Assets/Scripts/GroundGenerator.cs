using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {
	public GameObject groundPrefab;
	public GameObject stonePrefab;
	private float delta = 0f;
	private int span = 0;
	private float begin = 0;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update(){
	
		this.delta += Time.deltaTime;
		this.begin += Time.deltaTime;

		if(begin > 5)
        {
			if (this.delta > this.span)
			{
				this.delta = 0;
			
					int spwan = Random.Range(1, 5);
					if (spwan == 1)
					{
						GameObject Stone = Instantiate(stonePrefab) as GameObject;
						Stone.transform.position = new Vector2(15.0f,  -1.0f);

					}
					else if(spwan == 2)
					{
						GameObject Ground = Instantiate(groundPrefab) as GameObject;
						Ground.transform.position = new Vector2(15.0f, -1.0f);
					}
				this.span = 1;
			}

		}
	}
}	


