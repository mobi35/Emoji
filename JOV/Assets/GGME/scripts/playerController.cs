using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class playerController : MonoBehaviour {

	public float speed = 10;
	public Transform paggalaw;
	Rigidbody2D shooter;
	public Transform trans;
	bool isGround = true;
	public int score;
	public Text scores;
	public bool up;
	// Use this for initialization
	void Start () {
		up = false;
		shooter = this.GetComponent<Rigidbody2D> ();
		//paggalaw = this.transform;
	


	}





	// Update is called once per frame
	void FixedUpdate () 
	{
		scores.text = score.ToString ();

		if (Input.GetKey(KeyCode.D) && transform.position.x <= 0.8859 ) {
			trans.Translate (0, -0.060f, 0);
		}

		if (Input.GetKey(KeyCode.A) && transform.position.x >= -1.338  ) {
			trans.Translate (0, 0.060f, 0);
		}




		if (Input.GetKeyDown (KeyCode.Z)) {
			Instantiate (Resources.Load ("rock"), paggalaw.position, paggalaw.rotation);
			GameObject.Find ("rock(Clone)").GetComponent<Rigidbody2D> ().AddForce (new Vector2 (1f, 0f));

		}

	}



	public void Scoreup() {
		score += 5;
	}


	public void Scoredown() {
		score -= 5;
	}


}

