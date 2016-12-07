using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_Game : MonoBehaviour {

	public Transform canvas;
	public Transform Player;
	public Button Continue;
	public Button exit;
	AudioSource level_Music;
	int game_State;
	public Transform controls;
	public Transform back;

	void Start () 
	{
		game_State = 1;
		Time.timeScale = 1;
		level_Music = gameObject.GetComponent<AudioSource>();
		if (game_State == 0) {
			game_State = 1;
			Time.timeScale = 1;
		}
	}




	void Update () {
		if (Input.GetButtonDown("Cancel")) {
			Pause();
		}


	}

	public void ExitGame ()

	{
		Application.Quit();
	}

	public void Pause()
	{

		//Pauses the game if it isn't paused.
		if (canvas.gameObject.activeInHierarchy == false)
		{
			AudioListener.pause = true;
			level_Music.Pause();
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
			Player.GetComponent<FirstPersonController> ().enabled = false;
			Cursor.visible = true;
		} 

		//unpauses the game if it is paused.
		else 
		{
			AudioListener.pause = false;
			level_Music.UnPause();
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			Player.GetComponent<FirstPersonController> ().enabled = true;
		}

	}

	public void Resume()
	{
		level_Music.UnPause();
		canvas.gameObject.SetActive (false);
		Time.timeScale = 1;
		Player.GetComponent<FirstPersonController> ().enabled = true;


	}

	public void Controls() {
		if (controls.gameObject.activeInHierarchy == false) {
			controls.gameObject.SetActive (true);
			back.gameObject.SetActive (true);
		} 
		else {
			controls.gameObject.SetActive (false);
			back.gameObject.SetActive (false);
		}
	}



}
