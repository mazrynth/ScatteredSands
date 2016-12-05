using UnityEngine;
using System.Collections;

public class light_Pillar : MonoBehaviour 
{
	//Define:
	//Reference to sphere collider:
	public AudioClip activate;
	//public bool isActive;
	public GameObject GuidingLight;
	//public GameObject link_Bridge;
	public GameObject next_LightSpot;
	//public bool isFirst;
	public bool isTarget = false;


	//public float target_Rotation;
	//public rotate_Puzzle Rotate_Puzzle;



	// Use this for initialization
	void Start () 
	{
		//Vector3 startLocation = transform.position;[
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
			if(Input.GetMouseButtonDown(0))
			{
				GuidingLight.transform.position = next_LightSpot.transform.position;
				AudioSource.PlayClipAtPoint(activate, transform.position);
			}
		}
	}
}
