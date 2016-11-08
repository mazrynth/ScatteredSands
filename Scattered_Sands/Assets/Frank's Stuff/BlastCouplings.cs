using UnityEngine;
using System.Collections;

public class BlastCouplings : MonoBehaviour {

    public GameObject blastCouplings;
    GameObject clone;
    Vector3 dir = new Vector3(0,0,3);
    float cooldownTimer = 0;
    float fireDelay = 10.0f;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        cooldownTimer -= Time.deltaTime;

	    if(Input.GetKeyDown(KeyCode.F) && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            clone = Instantiate(blastCouplings, transform.position, transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(dir * 500);
            Debug.Log("Blast Coupling shot");
        }
	}
}
