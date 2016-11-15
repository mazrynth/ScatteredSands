using UnityEngine;
using System.Collections;

public class NavAgent2 : MonoBehaviour {


	public Transform[] waypoints;
	public float timer;
	public GameObject Ai;
	public GameObject player;
	public GameObject rock;
	public static NavMeshAgent agent;
	public int wp = 0;
	public static bool thrown;
	bool chasing_Player;
	//public bool stopped_Moving;

	// Use this for initialization
	void Start () 
	{
		agent = Ai.GetComponent <NavMeshAgent>();
		chasing_Player = false;
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
		timer = 0;
		if (wp == 4) 
		{
			wp = 0;
		}

		if (other.gameObject.CompareTag ("Player")) 
		{
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
			chasing_Player = false;
		} 
	}



	/*	//Was an experiment.
	public void stop_Moving()
	{
		stopped_Moving = true;
		agent.ResetPath();
	}
	*/

	void patrol_Points()
	{
		if(chasing_Player == false)
		{
			//print("Patroling!");
			//timer += Time.deltaTime;
			if (agent.remainingDistance < 0.5) 
			{
				if (wp == 0) 
				{
					agent.SetDestination (waypoints [wp++].position);
				} 
				else 
				{
					agent.SetDestination (waypoints [wp].position);
					wp++;
				}
			}
			if (wp == 4) 
			{
				wp = 0;
			}
		}
	}





}

