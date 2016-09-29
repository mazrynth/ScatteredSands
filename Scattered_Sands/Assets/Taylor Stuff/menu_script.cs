﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class menu_script : MonoBehaviour {


	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () 

	{
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();


	}
	
	void Update (){
		Time.timeScale = 1;
	}
		

	public void StartLevel()

	{
		SceneManager.LoadScene ("Level1");
	}

	public void ExitGame ()

	{
		Application.Quit ();
	}

}
