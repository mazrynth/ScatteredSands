using UnityEngine;
using System.Collections;

public class respawn_Node : MonoBehaviour 
{
	//Define variables:
	public bool isActive;
	GameObject[] respawnPoints;


	// Use this for initialization
	void Start () 
	{
		respawnPoints = GameObject.FindGameObjectsWithTag("Respawn");

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}




	public void SavePosition(GameObject other)
	{
		print("calling new save position");
		//Only activate if this respawnn point is not active:
		if(isActive == false)
		{
			print("now active");
			foreach (GameObject respawn in respawnPoints)
				{
					respawn.GetComponent<respawn_Node>().isActive = false;
				}
			other.GetComponent<respawn_Node>().isActive = true;
			PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
			PlayerPrefs.SetFloat ("PlayerY", transform.position.y);
			PlayerPrefs.SetFloat ("PlayerZ", transform.position.z);
		}
	}





}
