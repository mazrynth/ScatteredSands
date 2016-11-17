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
			goggles.gameObject.SetActive (true);
			gauntlet.gameObject.SetActive (false);
			blade.gameObject.SetActive (false);
			rock.gameObject.SetActive (false);
			goggles = goggles.GetComponent<Button> ();
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Gauntlet();
			gauntlet.gameObject.SetActive (true);
			goggles.gameObject.SetActive (false);
			blade.gameObject.SetActive (false);
			rock.gameObject.SetActive (false);
			gauntlet = gauntlet.GetComponent<Button> ();
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			Blade();
			blade.gameObject.SetActive (true);
			gauntlet.gameObject.SetActive (false);
			goggles.gameObject.SetActive (false);
			rock.gameObject.SetActive (false);
			blade = blade.GetComponent<Button> ();
		}
		/*if (Input.GetKeyDown (KeyCode.Alpha4)) {
			Rock();
			rock.gameObject.SetActive (true);
			gauntlet.gameObject.SetActive (false);
			blade.gameObject.SetActive (false);
			goggles.gameObject.SetActive (false);
			rock = rock.GetComponent<Button> ();
		}
		*/
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
