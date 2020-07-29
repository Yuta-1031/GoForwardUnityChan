using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollision : MonoBehaviour {
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
		audioSource = this.GetComponent<AudioSource>();
		if(tag == "UnityChan")
        {
			audioSource.Stop();
        }

		audioSource.Play();
    }
}
