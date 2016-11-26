using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "heart") {
			GameObject.Find ("Up").GetComponent<playerController> ().Scoreup ();
			Destroy (this.gameObject);
		}

		if (other.gameObject.tag == "stone") {
			GameObject.Find ("Up").GetComponent<playerController> ().Scoredown ();
			Destroy (this.gameObject);
		}
	}
}