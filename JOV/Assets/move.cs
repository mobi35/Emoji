using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	Rigidbody2D rb;
	public float movex;
	public float movey;
	public float Speed = 6f;
	public Controller joystick;
	public Sprite sprL;
	public Sprite sprR;
	public Sprite sprU;
	public Sprite sprD;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();	

	}



	public void SpriteUp() {
		GetComponent<SpriteRenderer> ().sprite = sprU;


	}

	public void SpriteDown() {
		GetComponent<SpriteRenderer> ().sprite = sprD;

	}

	public void SpriteLeft() {
		GetComponent<SpriteRenderer> ().sprite = sprL;

	}
	public void SpriteRight() {
		GetComponent<SpriteRenderer> ().sprite = sprR;

	}

	public void SpriteRes(){

	}
	// Update is called once per frame
	void Update () {
	

	
	}

	void FixedUpdate() {
		
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");

		movex = joystick.Horizontal ();
		movey = joystick.Vertical ();
		rb.velocity = new Vector2 (movex * Speed, movey * Speed);


	

	}
}
