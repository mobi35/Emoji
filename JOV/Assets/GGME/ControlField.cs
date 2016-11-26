using UnityEngine;
using System.Collections;

public class ControlField : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Q)) {
		transform.Rotate (0,0, 2);

		}

		if (Input.GetKey (KeyCode.E)) {
			transform.Rotate (0, 0, -2);

		}
	}
}
