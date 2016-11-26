using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	public bool left;
	public bool right;
	public bool up;
	public bool down;
	public GameObject Up;
	public GameObject Down;
	public GameObject Left;
	public GameObject Right;
	public int val;
	// Use this for initialization
	void Start () {
		//left = true;
	}




	
	// Update is called once per frame
	void Update () {
		val = PlayerPrefs.GetInt ("val");

		if(val == 1){

		

			Up.SetActive (true);

			Down.SetActive (false);
			Left.SetActive (false);
			Right.SetActive (false);
		}


		if (val == 2) {
			Down.SetActive (true);
			Up.SetActive (false);
			Left.SetActive (false);
			Right.SetActive (false);		

		}

		if ( val == 3) {
			
			Left.SetActive (true);
			Up.SetActive (false);

			Down.SetActive (false);

			Right.SetActive (false);
		}


		if (val == 4) {
			Right.SetActive (true);	
			Up.SetActive (false);

			Down.SetActive (false);
			Left.SetActive (false);

		}
	}
}
