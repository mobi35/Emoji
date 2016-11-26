using UnityEngine;
using System.Collections;

public class hit : MonoBehaviour {
	Rigidbody2D rb;
	//GameObject hero;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//hero = GameObject.Find ("hero").GetComponent<move> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void FixedUpdate() {
		if (GameObject.Find ("cols").GetComponent<cols> ().up) {
			rb.AddForce (new Vector2 (0, -40f));
		}
		if (GameObject.Find ("cols").GetComponent<cols> ().left) {
			rb.AddForce (new Vector2 (40, 0));
		}
		if (GameObject.Find ("cols").GetComponent<cols> ().down) {
			rb.AddForce (new Vector2 (0, 40f));
		}
		if (GameObject.Find ("cols").GetComponent<cols> ().right) {
			rb.AddForce (new Vector2 (-40, 0));
		}


	}


	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "pop") {
			Destroy (gameObject);
		
		}

		if (other.gameObject.tag == "bad") {
			Destroy (gameObject);
			GameObject.Find ("Main Camera").GetComponent<score> ().mb -= 10;
		}
	}
}
