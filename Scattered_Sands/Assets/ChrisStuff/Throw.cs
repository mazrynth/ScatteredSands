using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

	public GameObject throwPos;
	public GameObject rock;
	public static RaycastHit pub_thing;
	Camera camera;

	// Use this for initialization
	void Start () {
	
		camera = GetComponentInChildren<Camera> ();

	}
	
	// Update is called once per frame
	void Update () {
			
			if (Input.GetButtonDown ("Fire1") && ItemPickup.gotRock == true) {
				Instantiate(rock, throwPos.transform.position, throwPos.transform.rotation);
				GameObject clone = GameObject.FindGameObjectWithTag ("Rock");
				clone.GetComponent<Rigidbody>().AddForce (camera.transform.forward * 500);
				ItemPickup.gotRock = false;
				Debug.Log ("Throw");
			}
		}
	}
