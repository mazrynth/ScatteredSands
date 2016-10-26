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
			if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
			{
				Show ();
			}
	}

		public void Show()
		{

			if (canvas.gameObject.activeInHierarchy == false)
			{
				canvas.gameObject.SetActive (true);	
			} 

			else 
			{
				canvas.gameObject.SetActive (false);
			}

		}
}
