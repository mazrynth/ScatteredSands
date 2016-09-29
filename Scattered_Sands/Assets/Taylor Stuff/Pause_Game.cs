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


	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Pause();
		}


	}

	public void ExitGame ()

	{
		SceneManager.LoadScene ("Start_Menu");
	}

	public void Pause()
	{
		
			if (canvas.gameObject.activeInHierarchy == false)
			{
				canvas.gameObject.SetActive (true);
				Time.timeScale = 0;
				Player.GetComponent<FirstPersonController> ().enabled = false;
				Cursor.visible = true;
			} 

			else 
			{
				canvas.gameObject.SetActive (false);
				Time.timeScale = 1;
				Player.GetComponent<FirstPersonController> ().enabled = true;
			}

		}

	public void Resume(){
		canvas.gameObject.SetActive (false);
		Time.timeScale = 1;
		Player.GetComponent<FirstPersonController> ().enabled = true;
	
	
	}
	
	

}
