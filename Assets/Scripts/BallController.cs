using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
		Transform myTransform = this.transform;
		Vector2 ballpos = myTransform.position;
		ballpos.x += 1f;
		myTransform.position = ballpos;

		if(ballpos.x > 7)
        {
			Destroy(this.gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    
		if (other.gameObject.tag == "Cube")
		{

			Destroy(this.gameObject);
		}
	}
}
