using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ItemPickup : MonoBehaviour {

	public static bool haveRock = false;
	public static bool gotRock = false;
	public Image pic;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if (gotRock == true) {
			pic.gameObject.SetActive (true);
		}
		if (gotRock == false) {
			pic.gameObject.SetActive (false);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Collided");
		if (other.tag == "Item") 
		{

			Destroy (other.gameObject);
		}
		if (other.tag == "Rock") 
		{
			if (haveRock == false) {
				Destroy (other.gameObject);
				gotRock = true;
			}
		}
	}
}
