using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour 
{

	//public Transform Player;
	//int MaxDist = 2;

	public Transform canvas;
	public Button Restart;
	public Button MainMenu;
	public Button Exit;
	int game_State;
	public float max_health = 100f;
	public float cur_health = 0f;
	public Image Bar;
	//bool flag = false;
	//public CapsuleCollider collider1;
	public GameObject respawn_Point;
	public AudioSource[] audios_Exceptions;
	public bridge_Puzzle Bridge_Puzzle;


	public void Start () 
	{
		AudioListener.pause = false;
		//1 = running
		SavePosition();
		cur_health = max_health;
		game_State = 1;
		Time.timeScale = 1;
		Screen.lockCursor = true;
		//Player.GetComponent<FirstPersonController> ().enabled = true;
		GetComponent<FirstPersonController> ().enabled = true;


		if (game_State == 0) 
		{
			game_State = 1;
			Time.timeScale = 1;
		}

	}

	public void Update () 
	{      
		
	}


	void OnTriggerEnter (Collider other)
	{
		//Detect collision with respawn point
		if (other.gameObject.CompareTag ("Respawn"))  
		{
			//print("respawn point established");

			respawn_Node otherScript;
			otherScript = other.GetComponent<respawn_Node>();
			otherScript.SavePosition(other.gameObject);
			//SavePosition();
		}
	}






	public void decreaseHealth() 
	{
		cur_health -= 25f;
		float calc_health = cur_health/max_health;
		SetHealth (calc_health);

		//Game Over:
		if(cur_health <= 0)
		{
			Invoke("Show", 0.7f);
			//Show();
		}
	}
		
	void SetHealth(float myhealth)
	{
		Bar.fillAmount = myhealth;			
	}


	public void water_Death()
	{
		print ("water death");

		//Game Over:
		cur_health = 0;
		Bar.fillAmount = cur_health;
		Invoke("Show", 0.7f);
	}





	public void Show()
	{

		Bridge_Puzzle.reset_Puzzle();

		if (canvas.gameObject.activeInHierarchy == false)
		{
			AudioListener.pause = true;
			//AudioListener.volume = 0;
			//pause_AllSounds(true);
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
			//Player.GetComponent<FirstPersonController> ().enabled = false;
			GetComponent<FirstPersonController> ().enabled = false;
			Screen.lockCursor = false;
		} 

		else 
		{
			AudioListener.pause = false;
			//AudioListener.volume = 1;
			//pause_AllSounds(false);
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			//Unpause sound listener:

			//pause_AllSounds(false);
			//Player.GetComponent<FirstPersonController> ().enabled = true;
			GetComponent<FirstPersonController> ().enabled = true;
			Screen.lockCursor = true;
		}

	}
		
	 //moved to respawn_Node script.
	public void SavePosition()
		{
			PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
			PlayerPrefs.SetFloat ("PlayerY", transform.position.y);
			PlayerPrefs.SetFloat ("PlayerZ", transform.position.z);
		}


	public void Respawn() 
	{
			Show();
			cur_health = max_health;
			float calc_health = cur_health/max_health;
			SetHealth (calc_health);

			float x = PlayerPrefs.GetFloat ("PlayerX");
			float y = PlayerPrefs.GetFloat ("PlayerY");
			float z = PlayerPrefs.GetFloat ("PlayerZ");

			transform.position = new Vector3 (x, y, z);
	
	}








	//Should not need anymore.
	public void RestartLevel()
	{
		SceneManager.LoadScene (1);
		game_State = 1;
	}



	public void Menu ()

	{
		SceneManager.LoadScene ("Start_Menu");
	}


	public void ExitGame ()

	{
		Application.Quit ();
	}


	public void pause_AllSounds(bool is_Muted)
	{
		AudioSource[] audios = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

		if(is_Muted == true)
		{
			print("pausing all music!");
			foreach(AudioSource aud in audios)
			{
				aud.mute = true;
			}
		}

		else
		{
			print("unpausing all music!");
			foreach(AudioSource aud in audios)
			{
				aud.mute = false;
			}
		}
	}
}