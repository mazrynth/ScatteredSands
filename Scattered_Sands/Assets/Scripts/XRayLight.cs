using UnityEngine;
using System.Collections;

public class XRayLight : MonoBehaviour {

    public Light xray;
	// Use this for initialization
	void Start ()
    {
        xray = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(xray.enabled == false)
            {
                xray.enabled = true;
            }
            else
            {
                xray.enabled = false;
            }
        }
	
	}
}
