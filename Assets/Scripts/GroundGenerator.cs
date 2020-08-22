using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {
	
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
			
					int spwan = Random.Range(1, 10);
					if (spwan == 1)
					{
						

				}
					else if(spwan == 2)
					{
						
				}
				this.span = 1;
			}

		}
	}
}	


