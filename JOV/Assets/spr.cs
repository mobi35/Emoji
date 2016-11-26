using UnityEngine;
using System.Collections;

public class spr : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.childCount == 0) {
		
			GameObject.Find ("WinBoard").GetComponent<Canvas> ().enabled = true;
		}
			;
	}
}
