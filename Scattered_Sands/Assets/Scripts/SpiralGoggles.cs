using UnityEngine;
using System.Collections;

public class SpiralGoggles : MonoBehaviour {

    public Light splight;
    // Use this for initialization
    void Start()
    {
        splight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (splight.enabled == false)
            {
                splight.enabled = true;
            }
            else
            {
                splight.enabled = false;
            }
        }

    }
}
