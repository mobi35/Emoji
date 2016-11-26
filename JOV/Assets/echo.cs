using UnityEngine;
using System.Collections;

public class echo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<CircleCollider2D> ().enabled = true;
	}
}
