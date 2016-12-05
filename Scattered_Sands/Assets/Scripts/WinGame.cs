using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {

	public Transform Player;
	int MaxDist = 5;

	public Transform canvas;
	public Button Restart;
	public Button MainMenu;
	public Button Exit;
	int game_State;





	public void Start () 
	{
		print("Working2");
		//1 = running
		game_State = 1;
		Screen.lockCursor = true;
	}

	public void Update () 
	{      
		if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
		{
			if (game_State == 1) {
				Show ();
				game_State = 0;
			}
			/*print("Player Wins!");
			//Returns player to main menu:
			SceneManager.LoadScene ("Start_Menu");*/
		} 


	}

	public void Show()
	{
		
		if (canvas.gameObject.activeInHierarchy == false)
		{
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
			Player.GetComponent<FirstPersonController> ().enabled = false;
			Screen.lockCursor = false;
		} 

		else 
		{
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			Player.GetComponent<FirstPersonController> ().enabled = true;
			Screen.lockCursor = true;
		}

	}

	public void RestartLevel()

	{
		SceneManager.LoadScene (1);
	}

	public void Menu ()

	{
		SceneManager.LoadScene ("Start_Menu");
	}


	public void ExitGame ()

	{
		Application.Quit ();
	}







	/*print("Player Wins!");
			//Returns player to main menu:
	SceneManager.LoadScene ("Start_Menu");*/
} 

