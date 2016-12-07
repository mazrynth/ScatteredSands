using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

//Automatically adds an audiosource component to each object equipped with this script.
[RequireComponent (typeof (AudioSource))]

public class Play_Cutscene : MonoBehaviour 
{
	//Define:
	public MovieTexture movie;
	public AudioSource sound;
	//public bool disable_EndCutscene;

	//Reference the Player's game object:
	//public GameObject player;

	//NOTE: character and game is not paused during cut scene, needs to be fixed later.








	// Use this for initialization
	void Start () 
	{
		
			
		GetComponent<RawImage>().texture = movie as MovieTexture;		//Assigns the rawimage UI element's texture reference to become the movie.
		sound = GetComponent<AudioSource>();
		sound.clip = movie.audioClip;

		mute_All();
		//player.GetComponent<FirstPersonController> ().enabled = false;

		//Plays video and its audio.
		movie.Play();
		sound.Play();


	}

	// Update is called once per frame
	void Update () 
	{
		if(movie.isPlaying == false)
		{
			remove_Cutscene();
		}
			
		//End cutscene on key press.
		if(Input.GetKeyDown(KeyCode.Return))
		{
			print("Cutscene cancelled");
			remove_Cutscene();
		}
		if (Input.GetButtonDown("Submit"))
			remove_Cutscene();

	}



	void mute_All()
	{
		//Find all audio sources.
		AudioSource[] audios = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

		foreach(AudioSource aud in audios)
		{
			aud.volume = 0;
		}
			//Unmutes the cutscene's audio:
			sound.volume = 1;

	}



	//Gets rid of the cutscene and activates standard gameplay.
	void remove_Cutscene()
	{
		print("done playing cutscene!");


		//Find all audio sources.
		AudioSource[] audios = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

		foreach(AudioSource aud in audios)
		{
			aud.volume = 1;
		}

		//player.GetComponent<FirstPersonController> ().enabled = true;

		Destroy (gameObject);


	}
		

}
