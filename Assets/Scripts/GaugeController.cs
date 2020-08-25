using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour {
	Slider slider;
	float max = 5;
	Text gaugeText;

	// Use this for initialization
	void Start () {
		GManager.instance.gaugeMax = 0;
		slider = GetComponent<Slider>();
		slider.maxValue = max;
	
		this.gaugeText = GameObject.Find("GaugeText").GetComponent<Text>();
		this.gaugeText.text = GManager.instance.gaugeMax.ToString() + "/" + max;
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = GManager.instance.gaugeMax;
		this.gaugeText = GameObject.Find("GaugeText").GetComponent<Text>();
		this.gaugeText.text = slider.value.ToString() + "/" + max;
	}
}
