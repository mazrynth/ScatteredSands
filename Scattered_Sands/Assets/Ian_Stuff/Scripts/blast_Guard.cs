using UnityEngine;
using System.Collections;

public class blast_Guard : MonoBehaviour {


	public Transform[] waypoints;
	public AudioSource walk_Sound;
	public float timer;
	public GameObject Ai;
	public GameObject player;
	//public GameObject rock;
	public static NavMeshAgent agent;
	public int wp = 0;
	public static bool thrown;
	bool chasing_Player;
	//public bool stopped_Moving;
	public Game_Management game_Management;
	public int first_Point;
	public int second_Point;

	// Use this for initialization
	void Start () 
	{
		agent = Ai.GetComponent <NavMeshAgent>();
		//chasing_Player = false;
		//walk_Sound = GetComponent<AudioSource>();
		//walk_Sound.Play();
		//stopped_Moving = false;
		//print("new");
	}
	
	// Update is called once per frame
	void Update () 
	{
		patrol_Points();
	}



	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			//Play chase music:
			game_Management.play_Chase(true);

			chasing_Player = true;
			agent.SetDestination (other.transform.position);
			//print("entered");
			//PLAY CHASE MUSIC HERE.
		} 
	}

	void OnTriggerStay (Collider other)
	{

		if (other.gameObject.CompareTag ("Player")) 
		{
			agent.SetDestination (other.transform.position);
			//print("CHASING PLAYER!!!");
		} 

		if (other.gameObject.CompareTag ("Rock")) 
		{
			timer += Time.deltaTime;
			if (timer < 3) {
				agent.SetDestination (other.transform.position);
			} else {
				agent.SetDestination (waypoints [wp].position);

			}
		} 
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			game_Management.play_Chase(false);
			chasing_Player = false;
		} 
	}




	void patrol_Points()
	{
		print(wp);

		if(chasing_Player == false)
		{
			if (agent.remainingDistance < 0.5) 
			{
				if 	(wp == first_Point) 
				{
					agent.SetDestination(waypoints [second_Point].position);
					wp = second_Point;
				} 
				else if(wp == second_Point)
				{
					agent.SetDestination(waypoints [first_Point].position);
					wp = first_Point;

				}
			}
		}
	}





}

