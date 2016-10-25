using UnityEngine;
using System.Collections;


public class Gear_Pickup : MonoBehaviour 
{

	//Define References:

	//Reference to Game manager:
	public GameObject GM;

	//Reference to Game_Management script:
	Game_Management GM_Script;


	//Reference to Player transform:
	public Transform Player;
	public Transform gear_Object;
	public GameObject particle_Object;

	//Define Variables:
	int MaxDist = 4;
	public int icon_ID;	//Assigns the icon an ID, 1 = red, 2 = blue, 3 = green.

	// Use this for initialization
	void Start () 
	{
		//Initialize Variables:
		GM_Script = GM.GetComponent<Game_Management>();


	}

	// Update is called once per frame
	void Update () 
	{
		player_Detect();
	}




	//If player is within range...
	public void player_Detect()
	{
		//If Player is within range / distance:
		if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
		{
			//Call function from central game manager, Inputs the icon_ID value to tell it what gear was picked up.
			GM_Script.pickup_Gear(icon_ID);
		} 



	}
}
