using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour 
{

	public Transform Player;
	int MoveSpeed = 4;
	int MaxDist = 2;
	int MinDist = 2;




	public void Start () 
	{
		print("Working");
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
				//Returns player to main menu:
				SceneManager.LoadScene ("Start_Menu");
			} 

		}
		




	}
}
