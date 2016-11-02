using UnityEngine;
using System.Collections;

public class Anim_Test : MonoBehaviour {

	//Get References:
	Animator anim;		//Reference to the animator controller.




	// Use this for initialization
	void Start () 
	{
		//Establish reference:
		anim = GetComponent<Animator>();
		//anim.SetBool("Idle",false);
		//anim.SetBool("Walk",true);
		anim.SetTrigger("Attack");
		//anim.SetBool("Idle",true);


	}
	
	// Update is called once per frame
	void Update () 
	{
	



	}





}
