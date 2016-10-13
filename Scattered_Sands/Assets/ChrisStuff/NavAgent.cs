using UnityEngine;
using System.Collections;

public class NavAgent : MonoBehaviour {


	public Transform[] waypoints;
	public float timer;
	public GameObject Ai;
	public GameObject player;
	public GameObject rock;
	public static NavMeshAgent agent;
	public int wp = 0;
	public static bool thrown;


	// Use this for initialization
	void Start () {
		agent = Ai.GetComponent <NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {
		
		//timer += Time.deltaTime;
		if (agent.remainingDistance < 0.5) {
			if (wp == 0) {
				agent.SetDestination (waypoints [wp++].position);
			} else {
				agent.SetDestination (waypoints [wp].position);
				wp++;
			}
		}
			
		}

	void OnTriggerStay (Collider other){
		if (wp == 4) {
			wp = 0;
		}
		if (other.gameObject.CompareTag ("Player")) {
			player = other.gameObject;
			agent.SetDestination (player.transform.position);
		} else if (other.gameObject.CompareTag ("Rock")) {
			rock = other.gameObject;
			if (timer < 3 && thrown == true) {
				timer += Time.deltaTime;
				agent.SetDestination (rock.transform.position);
			} else {
				agent.SetDestination (waypoints [wp].position);
				thrown = false;
			}
		} 
	}
}

