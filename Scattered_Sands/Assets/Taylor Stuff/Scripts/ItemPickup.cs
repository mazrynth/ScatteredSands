using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ItemPickup : MonoBehaviour {

	public static bool gotRock = false;
	public Inventory inventory;

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
			inventory.AddItem (other.GetComponent<Item> ());
			Destroy (other.gameObject);
			gotRock = true;

		}
	}
}
