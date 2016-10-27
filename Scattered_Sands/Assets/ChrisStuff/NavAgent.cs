﻿using UnityEngine;
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
		if (wp == 4) {
			wp = 0;
		}
		}

	void OnTriggerEnter (Collider other){
		timer = 0;
		if (wp == 4) {
			wp = 0;
		}
		if (other.gameObject.CompareTag ("Player")) {
			agent.SetDestination (other.transform.position);
		} 
	}
	void OnTriggerStay (Collider other){
		if (other.gameObject.CompareTag ("Rock")) {
			timer += Time.deltaTime;
			if (timer < 3) {
				agent.SetDestination (other.transform.position);
			} else {
				agent.SetDestination (waypoints [wp].position);

			}
		} 
	}
}

