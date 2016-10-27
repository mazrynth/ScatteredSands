using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections.Generic;

public class ItemSelection : MonoBehaviour {

	public Button rock;
	public Button goggles;
	public Button gauntlet;
	public Button blade;
	// Use this for initialization


	void Start () {
		goggles = goggles.GetComponent<Button> ();
		gauntlet = gauntlet.GetComponent<Button> ();
		blade = blade.GetComponent<Button> ();
		rock = rock.GetComponent<Button> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Goggles();
			goggles = goggles.GetComponent<Button> ();
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Gauntlet();
			gauntlet = gauntlet.GetComponent<Button> ();
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			Blade();
			blade = blade.GetComponent<Button> ();
		}
		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			Rock();
			rock = rock.GetComponent<Button> ();
		}
	}

	public void Rock() {

	}

	public void Gauntlet() {
	
	}

	public void Blade() {

	}

	public void Goggles() {

	}
}
