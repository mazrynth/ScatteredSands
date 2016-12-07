using UnityEngine;
using System.Collections;

public class door_Blast : MonoBehaviour {

	//Define:
	public AudioClip activate;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	void OnTriggerStay (Collider other)
	{
		//if left mouse click is activated while rotation gauntlets are equipped:
		if (other.gameObject.CompareTag ("Player"))  
		{
			if(Input.GetButton("Select"))
			{
				AudioSource.PlayClipAtPoint(activate, this.gameObject.transform.position);
				Destroy(gameObject);
			}
		}
	}

}
