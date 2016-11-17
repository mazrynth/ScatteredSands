using UnityEngine;
using System.Collections;

public class pillar_Puzzle : MonoBehaviour 
{

	//Define variables:
	public GameObject guidingLight;
	Vector3 start_Location;
	public GameObject target_Door;
	public AudioClip activate;

	// Use this for initialization
	void Start () 
	{
		start_Location = guidingLight.transform.position;
		reset_Puzzle();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}







	public void reset_Puzzle()
	{
		print("resetting puzzle2");

		guidingLight.SetActive(true);
		guidingLight.transform.position = start_Location;





	}

	public void end_Puzzle()
	{
		AudioSource.PlayClipAtPoint(activate, target_Door.transform.position);
		target_Door.SetActive(false);
		guidingLight.SetActive(false);
	}





}
