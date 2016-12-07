using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achievement : MonoBehaviour {

	public Transform Player;
	int MaxDist = 5;

	public Transform canvas;

	// Use this for initialization
	void Start () {
	
	}
		
	
	// Update is called once per frame
	void Update () {
			/*if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
			{
				Show ();
			}*/
		if(Input.GetKeyDown(KeyCode.B))
			canvas.gameObject.SetActive (false);
		if (Input.GetButtonDown("Submit"))
			canvas.gameObject.SetActive (false);
	}

	private void OnTriggerEnter(Collider other)
	{	
		if (other.tag == "Player") {
			Show ();
			//Destroy (other.gameObject);
		}
	}

	public void Show()
		{

			if (canvas.gameObject.activeInHierarchy == false)
			{
				canvas.gameObject.SetActive (true);	
				StartCoroutine (Calm());
				
			} 

			

			else 
			{
				canvas.gameObject.SetActive (false);
			}

		}

		IEnumerator Calm() {
		yield return new WaitForSeconds (2);
		canvas.gameObject.SetActive (false);
		}
}
