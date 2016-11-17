using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour {

	public Transform Player;
	int MaxDist = 5;

	public Transform canvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.B))
			canvas.gameObject.SetActive (false);
	
	}
	private void OnTriggerEnter(Collider other)
	{	
		if (other.tag == "Player") {
			Show ();
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
