using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaugeBlockController : MonoBehaviour {
	public GameObject effectPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Ball"))
		{
			GameObject go = Instantiate(effectPrefab) as GameObject;
			go.transform.position = this.transform.position;

			GManager.instance.gaugeMax += 1;

			Destroy(this.gameObject);
		}
	}
}
