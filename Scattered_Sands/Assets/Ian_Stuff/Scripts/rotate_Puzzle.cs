using UnityEngine;
using System.Collections;

public class rotate_Puzzle : MonoBehaviour 
{
	//Define References:
	public GameObject statue1;
	public GameObject statue2;
	public GameObject statue3;
	public GameObject statue4;
	public GameObject statue5;
	public GameObject statue6;
	public GameObject target_Door;
	public AudioClip open_Door;

	//Define variables:
	public GameObject[] rotationStatues;


	// Use this for initialization
	void Start () 
	{
		//rotationStatues = GameObject.FindGameObjectsWithTag("Rotate");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	public void check_Puzzle()
	{
		/*
		int correct_Statues = 0;

		for(int i = 0; 0 < 6; i++)
		{
			if(rotationStatues[i].GetComponent<rotate_Statue>().isActive == false)
			{
				print("uhoh!");
				break;
			}

			else
			{
				correct_Statues += 1;
			}
		}

		if(correct_Statues == 6)
		{
			print("TA DA!!");
			this.enabled = false;
		}
	*/


		bool all_Active = true;
		foreach (GameObject rotationStatue in rotationStatues)
		{
			if(rotationStatue.GetComponent<rotate_Statue>().isActive == false)
			{
				print("nopeee");
				//Keep going...
				all_Active = false;
				return;
			}
		}


		if(all_Active == true)
		{
			print("TA DA!!");
			AudioSource.PlayClipAtPoint(open_Door, transform.position);
			Destroy (target_Door);

			this.enabled = false;
		}
	}
}
