using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class cols : MonoBehaviour {
	public Transform throwd;
	public Transform throwl;
	public Transform throwr;
	public Transform throwu;
	public bool up;
	public bool down;
	public bool left;
	public bool right;
	public Button btn;

	public move mvs;
	public int bullet = 5;
	public void Up() {
		up = true;


	}

	public void Down() {
		down = true;
	}

	public void Left() {
		left = true;
	}


	public void Right() {
		right = true;
	}

	public void Reset(){

		up = false;
		down = false;
		left = false;
		right = false;
	}

	// Use this for initialization
	void Start () {
	
	}

	public void hit() {
		if (up) {


			Instantiate (Resources.Load ("wew"), throwd.position, throwd.rotation);
			bullet -= 1;
		}

		if (left) {


			Instantiate (Resources.Load ("wew"), throwl.position, throwl.rotation);
			bullet -= 1;

		}
		if (right) {


			Instantiate (Resources.Load ("wew"), throwr.position, throwl.rotation);
			bullet -= 1;
		}


		if (down) {


			Instantiate (Resources.Load ("wew"), throwu.position, throwl.rotation);
			bullet -= 1;
		}


	}




	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "up") {
			Up ();
			mvs.SpriteDown ();
		
		}

		if (other.gameObject.tag == "left") {
			Left ();
			mvs.SpriteLeft ();
		

		}


		if (other.gameObject.tag == "right") {
			Right ();
			mvs.SpriteRight ();
		}



		if (other.gameObject.tag == "down") {
			Down ();
			mvs.SpriteUp ();
		}



	}
	void OnTriggerExit2D(Collider2D other){
		mvs.SpriteUp ();
		Reset ();
	}

}
