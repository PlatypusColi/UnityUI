using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ToggleTest : MonoBehaviour 
{
	ToggleGroup toggle_group_instance;

	public Toggle currentSelection
	{
		get {return (toggle_group_instance.ActiveToggles().FirstOrDefault());}
	}
	// Use this for initialization
	void Start ()
	{
		toggle_group_instance = GetComponent<ToggleGroup> ();
		Debug.Log ("First Selected " + currentSelection.name);

		SelectToggle (2);
	}
	
	public void SelectToggle(int id)
	{
		var toggles = toggle_group_instance.GetComponentsInChildren<Toggle> ();
		toggles [id].isOn = true;
	}
}
