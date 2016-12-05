using UnityEngine;
using System.Collections;

public class LevelStart : MonoBehaviour {
	int game_State;

	// Use this for initialization
	void Start () {
		game_State = 1;
		Time.timeScale = 1;

		if (game_State == 0) {
			game_State = 1;
			Time.timeScale = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
