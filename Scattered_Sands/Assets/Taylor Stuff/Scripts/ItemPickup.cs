using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ItemPickup : MonoBehaviour {


	public Inventory inventory;

	// Use this for initialization
	void Start() {
	
	}
	
	// Update is called once per frame
	void Update() {
		
	}

	private void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Item") 
		{
			inventory.AddItem (other.GetComponent<Item> ());
			//Destroy (other.gameObject);
			Debug.Log ("Collided");
		}
	}
}
