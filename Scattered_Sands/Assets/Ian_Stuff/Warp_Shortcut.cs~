using UnityEngine;
using System.Collections;

public class Warp_Shortcut : MonoBehaviour {

	//Define References:
	public GameObject teleport_Location;		//Reference to teleport location.
	string hitobject;


	// Use this for initialization
	void Start () 
	{
		print("Start?");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}



	void OnTriggerEnter(UnityEngine.Collider hit)
	{
		hitobject = hit.gameObject.tag;
		print("CC");
		if(hitobject == "Player")
		{
			print("Player teleported back");
			hit.transform.position = teleport_Location.transform.position;
		}

	}




}
