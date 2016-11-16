using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game_Management : MonoBehaviour 
{
	/*Description:
	Keeps track of global variables throughout the game, serves as a central controlling unit for everything. */

	//Define Variables:

	//Array of sound effects:
	public AudioClip[] sound_Effects;
	public AudioSource default_Music;
	public AudioSource chase_Music;


	//Array for gear booleans:
	public bool[] gear_Array;
	public bool[] gear_Array2;	//Tracks which gears have been placed.

	//Booleans to determine if Player is holding the red, green, blue gears.
	public bool has_Green;
	public bool has_Blue;
	public bool has_Red;
	public bool has_AllGears;

	//Image Icon References:
	public Image redIcon_Image;
	public Image blueIcon_Image;
	public Image greenIcon_Image;

	//Particle Effect References:
	public GameObject red_Particle;
	public GameObject blue_Particle;
	public GameObject green_Particle;

	//Gear Object References:
	public GameObject red_Gear;
	public GameObject blue_Gear;
	public GameObject green_Gear;

	//Gear Object References:
	public GameObject red_GearGoal;
	public GameObject blue_GearGoal;
	public GameObject green_GearGoal;

	//Gear Object References:
	//Refers to the actual gear, and not the podium, only used for hiding the gear's mesh renderer.
	public GameObject red_GearGoal2;
	public GameObject blue_GearGoal2;
	public GameObject green_GearGoal2;

	//Gear placement references:
	MeshRenderer red_GearPlacement;
	MeshRenderer blue_GearPlacement;
	MeshRenderer green_GearPlacement;

	//Reference to Door object:
	public GameObject secret_Door;	//Unlocks when all 3 gears are placed



	// Use this for initialization
	void Start () 
	{
		gear_Array = new bool[3];
		gear_Array2 = new bool[3];


		red_GearPlacement = red_GearGoal2.GetComponentInChildren<MeshRenderer>();
		blue_GearPlacement = blue_GearGoal2.GetComponentInChildren<MeshRenderer>();
		green_GearPlacement = green_GearGoal2.GetComponentInChildren<MeshRenderer>();

		//Initially hide the Gear placements:
		red_GearPlacement.enabled = false;
		blue_GearPlacement.enabled = false;
		green_GearPlacement.enabled = false;



		/*
		has_Green = false;
		has_Blue = false;
		has_Red = false;
		*/

		//Initalize Variables:
		//Hide the gear icons:
		redIcon_Image.enabled = false;
		blueIcon_Image.enabled = false;
		greenIcon_Image.enabled = false;
		has_AllGears = false;

		for(int i = 0; i < 3; i++)
		{
			//print(i);
			gear_Array[i] = false;
			gear_Array2[i] = false;

		}

		/*
		for(int i = 0; i < 3; i++)
		{
			print(gear_Array[i]);
		}
		*/


	}





	// Update is called once per frame
	void Update () 
	{
	
	}









	public void print_Test()
	{
		print("Hi");

	}

	public void pickup_Gear(int gear_ID)
	{
		print("Gear pickup");
		print(gear_ID);


		//If this is the Red Gear...
		if(gear_ID == 1)
		{ 
			//has_Red = true;
			//Play gear pickup sound:
			AudioSource.PlayClipAtPoint(sound_Effects[1], red_Gear.transform.position);
			gear_Array[0] = true;
			redIcon_Image.enabled = true;
			//Destroy (red_Particle);
			Destroy (red_Gear);
			red_Particle.transform.position = red_GearGoal.transform.position;
		}

		//If this is the Blue gear...
		else if(gear_ID == 2)
		{
			//has_Blue = true;
			//Play gear pickup sound:
			AudioSource.PlayClipAtPoint(sound_Effects[1], blue_Gear.transform.position);
			gear_Array[1] = true;
			blueIcon_Image.enabled = true;
			//Destroy (blue_Particle);
			Destroy (blue_Gear);
			blue_Particle.transform.position = blue_GearGoal.transform.position;
		}

		//If this is the Green Gear...
		else if(gear_ID == 3)
		{
			//has_Green = true;
			//Play gear pickup sound:
			AudioSource.PlayClipAtPoint(sound_Effects[1], green_Gear.transform.position);
			gear_Array[2] = true;
			greenIcon_Image.enabled = true;
			//Destroy (green_Particle);
			Destroy (green_Gear);
			green_Particle.transform.position = green_GearGoal.transform.position;
		}

		//Destroy (red_Particle);
		//Destroy (gameObject);

	}



	public int drop_Gear(int gear_ID)
	{
		print("Function Call: Dropped Gear");

		print(gear_ID);


		//If this is the Red Gear...
		if(gear_ID == 1)
		{ 
			if(gear_Array[0] == true)
			{
				AudioSource.PlayClipAtPoint(sound_Effects[1], red_GearPlacement.transform.position);
				gear_Array2[0] = true;
				gear_Array[0] = false;
				redIcon_Image.enabled = false;
				Destroy (red_Particle);
				red_GearPlacement.enabled = true;
				check_HasAllGears();
				return 1;
			}

			else 
			{
				return 0;
			}
		}

		//If this is the Blue gear...
		else if(gear_ID == 2)
		{
			if(gear_Array[1] == true)
			{
				AudioSource.PlayClipAtPoint(sound_Effects[1], blue_GearPlacement.transform.position);
				gear_Array2[1] = true;
				gear_Array[1] = false;
				blueIcon_Image.enabled = false;
				Destroy (blue_Particle);
				blue_GearPlacement.enabled = true;
				check_HasAllGears();
				return 1;
			}

			else 
			{
				return 0;
			}
		}

		//If this is the Green Gear...
		else if(gear_ID == 3)
		{

			if(gear_Array[2] == true)
			{
				AudioSource.PlayClipAtPoint(sound_Effects[1], green_GearPlacement.transform.position);
				gear_Array2[2] = true;
				gear_Array[2] = false;
				greenIcon_Image.enabled = false;
				Destroy (green_Particle);
				green_GearPlacement.enabled = true;
				check_HasAllGears();
				return 1;
			}

			else 
			{
				return 0;
			}
		}

		else 
		{
			return 0;
		}
	}



	public void check_HasAllGears()
	{
		print("Checking all gears");
		for(int i = 0; i < 3; i++)
		{
			if(gear_Array2[i] == true)
			{
				print("a gear!");

			}

			//else if one of the gears is missing...
			else if(gear_Array2[i] == false)
			{
				//Break / stop checking:
				print("missing a gear");
				return;
			}

		}

		print("Has all three gears!");
		AudioSource.PlayClipAtPoint(sound_Effects[2], secret_Door.transform.position);
		Destroy (secret_Door);
	}



	public void play_Chase(bool isPlaying)
	{
		//If chase music should activate...
		if(isPlaying == true)
		{
			default_Music.Pause();
			chase_Music.Play();
		}

		//else the default music resumes...
		else
		{
			default_Music.UnPause();
			chase_Music.Stop();
		}
	}












}
