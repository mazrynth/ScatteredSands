using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public RaycastHit pub_thing;
	public Transform pickup;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		Ray line = Camera.main.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (line.origin, line.direction * 200000, Color.yellow);
		RaycastHit thing;
		if (Physics.Raycast (this.transform.position, line.direction, out thing, 10) && Input.GetKeyDown (KeyCode.E)) {
			pub_thing = thing;
			if (pub_thing.transform.tag == "Rock") {
				pub_thing.transform.position = pickup.transform.position;
				pub_thing.transform.SetParent (pickup);
				pub_thing.rigidbody.useGravity = false;
				pub_thing.rigidbody.isKinematic = true;
				Debug.Log ("Picked");
			}
		}
			if (Input.GetButtonDown ("Fire1")) {
				NavAgent.thrown = true;
				pub_thing.rigidbody.isKinematic = false;
				pub_thing.rigidbody.useGravity = true;
				pickup.DetachChildren ();
				pub_thing.rigidbody.AddForce (Camera.main.transform.forward * 500);
				Debug.Log ("Throw");
			}
		}
	}
