using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour {

	public Transform Player;
	int MaxDist = 5;
	public AudioSource mySound;


	public Transform canvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Deselect")) {
			canvas.gameObject.SetActive (false);
			mySound.Stop ();
		}
	
	}
	private void OnTriggerEnter(Collider other)
	{	
		if (other.tag == "Player") {
			Show ();
			mySound.Play();


		}
	}

	public void Show()
	{
		if (canvas.gameObject.activeInHierarchy == false)
		{
			canvas.gameObject.SetActive (true);	
		}
}
}
