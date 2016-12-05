using UnityEngine;
using System.Collections;

public class BlastCouplings : MonoBehaviour {

    public GameObject blastCouplings;
    //GameObject clone;
    float cooldownTimer = 0;
    float fireDelay = 20.0f;
    public Transform shootPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

		if (Input.GetButtonDown ("Fire3") && cooldownTimer <= 0)
        {
            GameObject clone = Instantiate(blastCouplings, shootPos.position, shootPos.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(shootPos.forward * 2500);
            Debug.Log("Blast Coupling shot");
            cooldownTimer = fireDelay;
        }
    }
}
