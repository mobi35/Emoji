using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManagement : MonoBehaviour 
{

	public float startingTime;

	private Text theText;

	// Use this for initialization
	void Start () 
	{
	
		theText = GetComponent<Text> ();


	}
	
	// Update is called once per frame
	void Update () 
	{

		startingTime -= Time.deltaTime;

		theText.text = "" + Mathf.Round (startingTime);
	
	}
}
