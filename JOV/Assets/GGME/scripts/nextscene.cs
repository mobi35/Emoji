using UnityEngine;
using System.Collections;

public class nextscene : MonoBehaviour {

	public void nextlevel(string levelname)
	{
		Application.LoadLevel (levelname);
	}

}
