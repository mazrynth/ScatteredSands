using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Toggle_Icon : MonoBehaviour 
{

	//Define References:

	//Reference to THIS icon Image:
	Image icon_Image;

	//Reference to Game manager:
	public GameObject GM;

	//Reference to Game_Management script:
	Game_Management GM_Script;

	//Define Variables:
	public int icon_ID;	//Assigns the icon an ID, 1 = red, 2 = blue, 3 = green.


	// Use this for initialization
	void Start () 
	{

		//Initialize Variables:
		//cg = gameObject.GetComponent<CanvasGroup>();
		icon_Image = gameObject.GetComponent<Image>();
		GM_Script = GM.GetComponent<Game_Management>();
		icon_Image.enabled = false;





	}
	
	// Update is called once per frame
	void Update () 
	{

	}




	public void toggle_Icon()
	{
		print("Toggling Icon");
		//cg.alpha = 0f; //this makes everything transparent


		//RED
		if(icon_ID == 1)
		{

			//Has red gear, and is now dropping it:
			if(GM_Script.has_Red == true)
			{
				GM_Script.has_Red = false;
				icon_Image.enabled = false;
			}

			//does not have red gear, and is now picking it up:
			else if(GM_Script.has_Red == false)
			{
				GM_Script.has_Red = true;
				icon_Image.enabled = true;

			}
		}

		//Blue
		else if(icon_ID == 2)
		{


		}


		//Green
		else if(icon_ID == 3)
		{



		}



	}






}







