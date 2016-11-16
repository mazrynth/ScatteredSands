using UnityEngine;
using System.Collections;

public class Mummy_Attacker : MonoBehaviour 
{
	//Define Variables:
	public AudioSource attack_Sound;
	public Transform Player;
	//int MaxDist = 2;
	public int attack_Speed = 100;
	private IEnumerator attack_Cooldown;
	bool mummy_Cooldown;
	Player_Health health_Script;

	//public Player_Health health_Script;

	//Get Animator:
	Animator anim;


	public void Start () 
	{
		print("Mummy attacker active");
		//attack_Cooldown = attack();			//Assigns the coroutine to the function.
		mummy_Cooldown = false;				
		anim = GetComponentInParent<Animator>();
		health_Script = Player.GetComponent<Player_Health>();
		attack_Sound = GetComponent<AudioSource>();
		/*
		//Test:
		print("Test call" + health_Script.max_health);
		health_Script.decreaseHealth();
		print("Test call2" + health_Script.cur_health);
		*/
	}

	public void Update () 
	{      
		
	}



	void OnTriggerEnter (Collider other)
	{
		if (other.transform == Player) 
		{
			print("Cooldown?" + mummy_Cooldown);
			if (mummy_Cooldown == false) 
			{
				attack_Sound.Play();
				print("RAWR!");
				anim.SetTrigger("Attack");
				mummy_Cooldown = true;	
				health_Script.decreaseHealth();
				//StartCoroutine(attack_Cooldown);	//Calls the coroutine
				Invoke("attack", attack_Speed);
			}
		}
	}

	void OnTriggerStay (Collider other)
	{
		if (other.transform == Player) 
		{
			print("Cooldown?" + mummy_Cooldown);
			if (mummy_Cooldown == false) 
			{
				print("RAWR!");
				anim.SetTrigger("Attack");
				mummy_Cooldown = true;	
				health_Script.decreaseHealth();
				//StartCoroutine(attack_Cooldown);	//Calls the coroutine
				Invoke("attack", attack_Speed);
			}
		}
	}
		
	void attack() 
	{
		//yield return new WaitForSeconds(attack_Speed);
		mummy_Cooldown = false;	
		print("Enemy Attack Cooldown done");
		//StopCoroutine(attack_Cooldown);


		/*
		while(mummy_Attacking == true)
		{
			print("Mummy Attacking!");
			yield return new WaitForSeconds (attack_Speed);
			mummy_Attacking = false;
			StopCoroutine(attack_Cooldown);			//Ends the coroutine so it isn't running needlessly.
		}
		*/
		//StopCoroutine(attack_Cooldown);			//Ends the coroutine so it isn't running needlessly.
		//mummy_Attacking = false;
	}

}
