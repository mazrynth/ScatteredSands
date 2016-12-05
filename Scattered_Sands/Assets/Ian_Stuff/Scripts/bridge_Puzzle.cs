using UnityEngine;
using System.Collections;

public class bridge_Puzzle : MonoBehaviour 
{

	//Define variables:
	GameObject[] bridges;
	GameObject[] guards;
	public GameObject guidingLight;
	public GameObject sandStorm;
	Vector3 start_Location;


	// Use this for initialization
	void Start () 
	{
		bridges = GameObject.FindGameObjectsWithTag("Bridge");
		guards = GameObject.FindGameObjectsWithTag("guard");
		start_Location = guidingLight.transform.position;
		reset_Puzzle();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}







	public void reset_Puzzle()
	{
		print("resetting puzzle");

		guidingLight.SetActive(true);
		sandStorm.SetActive(true);
		guidingLight.transform.position = start_Location;

		foreach (GameObject Bridge in bridges)
		{
			Bridge.SetActive(false);
		}

		foreach (GameObject guard in guards)
		{
			guard.SetActive(true);
		}



	}

	public void end_Puzzle()
	{
		sandStorm.SetActive(false);
		guidingLight.SetActive(false);
		foreach (GameObject guard in guards)
		{
			guard.SetActive(false);
		}
	}





}
