using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderTest : MonoBehaviour 
{
	public Slider slider_instance;

	public void Start ()
	{
		slider_instance.minValue = 0;
		slider_instance.maxValue = 100;
		slider_instance.wholeNumbers = true;
		slider_instance.value = 50;
	}

	public void OnValueChanged(float value)
	{
		Debug.Log ("New Value " + value);
	}

}
