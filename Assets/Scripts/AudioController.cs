using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {
	AudioSource audioSource;	
	// Use this for initialization
	void Start () {
		
		audioSource = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "UnityChan")
		{
			audioSource.Stop();
			//Debug.Log("衝突");
		}
		else
		{
		audioSource.Play();
		}
	}
	
}
