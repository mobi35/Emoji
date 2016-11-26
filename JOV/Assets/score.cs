using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class score : MonoBehaviour {
	public Text sc;

	public Text time;
	public Text wsc;

	public Text wtime;
	public int mb;
	public float countdown;
	public cols bul;
	public Text buls;
	// Use this for initialization
	void Start () {
		countdown = 60;
	}
	
	// Update is called once per frame
	void Update () {

		if (countdown <= 0) {
			GameObject.Find ("Gameover").GetComponent<Canvas> ().enabled = true;
		}

		if (bul.bullet <= 0) {
			GameObject.Find ("Gameover").GetComponent<Canvas> ().enabled = true;
		}
		buls.text = "Bullet: " + bul.bullet;
		countdown -= Time.deltaTime;
		time.text = "Time: " + (int)countdown;
		sc.text = "Score: " + mb;

		//wtime.text = "Time: " + (int)countdown;
		wsc.text = "Score: " + mb;

	}
}
