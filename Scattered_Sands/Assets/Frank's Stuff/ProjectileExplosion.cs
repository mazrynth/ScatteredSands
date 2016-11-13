using UnityEngine;
using System.Collections;

public class ProjectileExplosion : MonoBehaviour {

    float radius = 5.0f;
    float power = 10.0f;
    float explosiveLift = 1.0f;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 Origin = transform.position;
        Collider[] colliders = Physics.OverlapSphere(Origin, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(power, Origin, radius, 3.0f);
                Destroy(gameObject, 3);
            }
        }
    }
}
