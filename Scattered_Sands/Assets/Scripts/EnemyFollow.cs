using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour 
{

	public Transform Player;
	int MoveSpeed = 4;
	int MaxDist = 2;
	int MinDist = 2;
	public float max_health = 100f;
	public float cur_health = 0f;
	public Image Bar;
	public Transform canvas;
	public Button Restart;
	public Button MainMenu;
	public Button Exit;
	int game_State;




	public void Start () 
	{
		print("Working");
		cur_health = max_health;
	}

	public void Update () 
	{
		transform.LookAt(Player);

		if(Vector3.Distance(transform.position,Player.position) >= MinDist)
		{
			//GO towards Player.
			transform.position += transform.forward*MoveSpeed*Time.deltaTime;



			if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
			{
				//Player has been caught.
				//Here Call any function U want Like Shoot at here or something
				print("Meow!");
				decreaseHealth ();

			} 

		}
		




	}

	/*void Start () {
		cur_health = max_health;
		//InvokeRepeating ("decreaseHealth", 0f, 2f);
	}*/


	/*void OnCollisionEnter(Collider _collision) {
		if (_collision.gameObject.tag == "Enemy") {
			decreaseHealth();
		}
	}*/

	void decreaseHealth() {

		cur_health -= 25f;
		float calc_health = cur_health/max_health;
		SetHealth (calc_health);
		
		
	if(cur_health <= 0)
		Show();
	}
	

	void SetHealth(float myhealth){
		Bar.fillAmount = myhealth;			
	}

public void Show()
{

	if (canvas.gameObject.activeInHierarchy == false)
	{
		canvas.gameObject.SetActive (true);
		Time.timeScale = 0;
		Player.GetComponent<FirstPersonController> ().enabled = false;
		Screen.lockCursor = false;
		Cursor.visible = true;
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
	SceneManager.LoadScene ("Level1");
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


