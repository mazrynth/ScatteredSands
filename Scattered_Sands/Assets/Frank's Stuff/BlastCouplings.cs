using UnityEngine;
using System.Collections;

public class BlastCouplings : MonoBehaviour {

    public GameObject blastCouplings;
    //GameObject clone;
    Vector3 dir = new Vector3(0, 0, 5);
    float cooldownTimer = 0;
    float fireDelay = 20.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.F) && cooldownTimer <= 0)
        {
            GameObject clone = Instantiate(blastCouplings, transform.position, Quaternion.identity) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(dir * 700);
            Debug.Log("Blast Coupling shot");
            cooldownTimer = fireDelay;
        }
    }
}
