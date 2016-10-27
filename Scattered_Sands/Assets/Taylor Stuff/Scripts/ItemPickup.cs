using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ItemPickup : MonoBehaviour {

	public static bool gotRock = false;

	// Use this for initialization
	void Start() {
	
	}
	
	// Update is called once per frame
	void Update() {
		
	}

	public void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Collided");
		if (other.tag == "Item") 
		{
			Destroy (other.gameObject);
		}
		if (other.tag == "Rock") 
		{
			Destroy (other.gameObject);
			gotRock = true;
		}
	}
}
