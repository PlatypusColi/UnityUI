using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTest : MonoBehaviour
{
	public string message;

	private Text text_instance;

	// Use this for initialization
	void Start ()
	{
		text_instance = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		text_instance.text = message;
	}
}
