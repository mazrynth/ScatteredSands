using UnityEngine;
using System.Collections;

public class Save : MonoBehaviour {

	public void SavePosition()
	{
		PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
		PlayerPrefs.SetFloat ("PlayerY", transform.position.y);
		PlayerPrefs.SetFloat ("PlayerZ", transform.position.z);
	}

	public void LoadPosition()
	{
		float x = PlayerPrefs.GetFloat ("PlayerX");
		float y = PlayerPrefs.GetFloat ("PlayerY");
		float z = PlayerPrefs.GetFloat ("PlayerZ");

		transform.position = new Vector3 (x, y, z);
	}
}
