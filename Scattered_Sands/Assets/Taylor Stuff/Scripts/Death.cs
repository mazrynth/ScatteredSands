using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	public Transform Player;
	int MaxDist = 2;

	public Transform canvas;
	public Button Restart;
	public Button MainMenu;
	public Button Exit;
	int game_State;
	public float max_health = 100f;
	public float cur_health = 0f;
	public Image Bar;
	bool flag = false;
	public CapsuleCollider collider1;
	public GameObject box;




	public void Start () 
	{
		//1 = running
		cur_health = max_health;
		game_State = 1;
		Time.timeScale = 1;
		Screen.lockCursor = true;
		Player.GetComponent<FirstPersonController> ().enabled = true;

		if (game_State == 0) {
			game_State = 1;
			Time.timeScale = 1;
		}

	}

	public void Update () 
	{      
		//Replaced old death trigger.
		/*
		if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
		{
			if (game_State == 1) {
				Show ();
				game_State = 0;
			}
		} 
		*/
		if (flag)
			Calm ();
			
	}


	void OnTriggerEnter (Collider other)
	{
		//if(other.gameObject.name == Player.name)
		//{
			print("Player hit");


			if (other == collider1) {
				//Add health bar check system here
				decreaseHealth ();
				print("Player hit2");

			if (other == box) {
				SavePosition ();
			}


			}


			/*if (game_State == 1) {
				Show ();
				game_State = 0;
			}*/
		//} 
	}

	void decreaseHealth() {
		

		cur_health -= 25f;
		float calc_health = cur_health/max_health;
		SetHealth (calc_health);
		flag = true;

		//StartCoroutine(Calm());


		if(cur_health <= 0)
			Show();
	}


	void SetHealth(float myhealth){
		Bar.fillAmount = myhealth;			
	}


	IEnumerator Calm() {
		print("Player hit2");
		yield return new WaitForSeconds (5);

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
		
	public void SavePosition()
		{
			PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
			PlayerPrefs.SetFloat ("PlayerY", transform.position.y);
			PlayerPrefs.SetFloat ("PlayerZ", transform.position.z);
		}


	public void Respawn() {
		
			float x = PlayerPrefs.GetFloat ("PlayerX");
			float y = PlayerPrefs.GetFloat ("PlayerY");
			float z = PlayerPrefs.GetFloat ("PlayerZ");

			transform.position = new Vector3 (x, y, z);
	
	}

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
}