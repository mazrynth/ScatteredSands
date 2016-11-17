using UnityEngine;
using System.Collections;

public class rotate_Statue : MonoBehaviour 
{
	//Define:
	//Reference to sphere collider:
	public AudioClip activate;
	public bool isActive;
	public float target_Rotation;
	public rotate_Puzzle Rotate_Puzzle;



	// Use this for initialization
	void Start () 
	{
		isActive = false;
		random_Rotate();
		check_Rotation();
		Rotate_Puzzle.check_Puzzle();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
		


	void OnTriggerStay (Collider other)
	{
		//if left mouse click is activated while rotation gauntlets are equipped:
		if (other.gameObject.CompareTag ("Player"))  
		{
			if(Input.GetMouseButtonDown(0))
			{
				//rotate this object 90 degrees.
				//Vector3 eulerAngles = transform.rotation.eulerAngles;
				//print("object rotated!");

				Vector3 eulerAngles = transform.rotation.eulerAngles;
				//print("transform.rotation angles x: " + eulerAngles.x + "y: " + eulerAngles.y + " z: " + eulerAngles.z);
				eulerAngles.y += 45;
				transform.rotation = Quaternion.Euler(eulerAngles);

				AudioSource.PlayClipAtPoint(activate, transform.position);
				//print("transform.rotation angles x: " + eulerAngles.x + "y: " + eulerAngles.y + " z: " + eulerAngles.z);

				//CALL CHECK FUNCTION TO SEE IF ALL 6 STATUES ARE FACING RIGHT WAY:
				check_Rotation();
				//GetComponentInParent<rotate_Puzzle>().check_Puzzle();
				Rotate_Puzzle.check_Puzzle();
			}
		}
	}







	void random_Rotate()
	{
		int random_Direction;
		Vector3 eulerAngles = transform.rotation.eulerAngles;
		random_Direction = Random.Range(0,3);
		//print("Random direction " + random_Direction);
		//print("transform.rotation angles x: " + eulerAngles.x + "y: " + eulerAngles.y + " z: " + eulerAngles.z);
		random_Direction = random_Direction * 90;

		eulerAngles.y = random_Direction;
		transform.rotation = Quaternion.Euler(eulerAngles);
		//print("transform.rotation angles x: " + eulerAngles.x + "y: " + eulerAngles.y + " z: " + eulerAngles.z);
	}



	void check_Rotation()
	{
		Vector3 angle = transform.rotation.eulerAngles;
		print(angle.y);
		print(target_Rotation);

		if((Mathf.Round(angle.y)) == target_Rotation)
		{
			print("correct rotation!");
			isActive = true;
		}

		else
		{
			isActive = false;
		}


	}


}
