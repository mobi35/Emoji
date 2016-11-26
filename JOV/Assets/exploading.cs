using UnityEngine;
using System.Collections;

public class exploading : MonoBehaviour {
	public int score;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other){
	
		if (other.gameObject.tag == "hit" ) {
			GetComponentInChildren<echo> ().enabled = true;
			GameObject.Find ("Main Camera").GetComponent<score> ().mb += 10;
			StartCoroutine ("expload");
		}

	}

	public IEnumerator expload(){
		

		yield return new WaitForSeconds (2f);
		Destroy (this.gameObject);
	}
}
