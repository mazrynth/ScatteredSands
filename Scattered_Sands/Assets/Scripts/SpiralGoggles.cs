using UnityEngine;
using System.Collections;

public class SpiralGoggles : MonoBehaviour {

    public Light splight;
    public float coolDown = 20;
    public float coolDownTimer;

    // Use this for initialization
    void Start()
    {
        splight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
           //if (splight.enabled == false)
            //{
                //splight.enabled = true;
            //}
            //else
            //{
                //splight.enabled = false;
            //}
        //}

        if(coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if(coolDownTimer < 0)
        {
            coolDownTimer = 0;
        }

        if(Input.GetKeyDown(KeyCode.R) && coolDownTimer == 0)
        {
            enableLight();
            coolDownTimer = coolDown;
        }

    }

    void enableLight()
    {
        if(splight.enabled == false)
        {
            splight.enabled = true;
        }
    }
}
