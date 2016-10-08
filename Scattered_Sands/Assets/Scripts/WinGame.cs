using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {

	public Transform Player;
	int MaxDist = 5;





	public void Start () 
	{
		print("Working2");
	}

	public void Update () 
	{      
		if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
		{

			print("Player Wins!");
			//Returns player to main menu:
			SceneManager.LoadScene ("Start_Menu");
		} 


	}
}
