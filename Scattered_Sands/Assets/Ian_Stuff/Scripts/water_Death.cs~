using UnityEngine;
using System.Collections;

public class water_Death : MonoBehaviour 
{
	//Define variables:
	public bridge_Puzzle Bridge_Puzzle;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	void OnTriggerEnter (Collider other)
	{
		//Detect collision with respawn point
		if (other.gameObject.CompareTag ("Player"))  
		{
			Bridge_Puzzle.reset_Puzzle();
			other.GetComponentInChildren<Player_Health>().water_Death();
		}
	}

}
