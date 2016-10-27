using UnityEngine;
using System.Collections;

public class Gear_Drop : MonoBehaviour 
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
		//print("Detecting player...");
	
		for(int i = 0; i < 3; i++)
		{
			//print(i);
			//Check if Player even has a gear:
			if(GM_Script.gear_Array[i] == true)
			{
				//print("There is a gear!");
				if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
				{
					//Call function from central game manager, Inputs the icon_ID value to tell it what gear was picked up.
					GM_Script.drop_Gear(icon_ID);
					print("Kapoof");

					print("Return Value:" + GM_Script.drop_Gear(icon_ID));
					if(GM_Script.drop_Gear(icon_ID) == 1)
					{
						print("Function returned 1");
						Destroy (this);
					}

				} 
			}

		}








	}
}
