using UnityEngine;
using System.Collections;

public class SpiralGoggles : MonoBehaviour {

    public Light splight;
    GameObject dazed;
    public float stun;
    public bool stunned = false;
    //public float coolDown;
    //public float coolDownTimer;
    //public float timeLimit;
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


        //if(coolDownTimer > 0)
        //{
            //coolDownTimer -= Time.deltaTime;
        //}

        //if(coolDownTimer < 0)
        //{
            //coolDownTimer = 0;
        //}

        //if (timeLimit > 0) 
        //{
            //timeLimit -= Time.deltaTime;

        //}

        //if (timeLimit < 0)
        //{
            //timeLimit = 0;
        //}

        //if (Input.GetKeyDown(KeyCode.R) && coolDownTimer == 0)
        //{
           
            //enableLight();

            //if (timeLimit == 0)
            //{
                //CoolDown();
                //timeLimit = 20;
            //}

            
        //}

    }

    //void enableLight()
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

    //void CoolDown()
    //{
        //if(splight.enabled == true)
        //{
            //splight.enabled = false;
        //}
        //coolDownTimer = coolDown;
    //}
}
