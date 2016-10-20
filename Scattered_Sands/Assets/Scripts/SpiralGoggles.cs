using UnityEngine;
using System.Collections;

public class SpiralGoggles : MonoBehaviour {

    public Light splight;
    public GameObject dazed;
    public NavMeshAgent nav;
    public float stun = 0;
    public bool stunned = false;

    //public float coolDown;
    //public float coolDownTimer;
    //public float timeLimit;
    // Use this for initialization
    void Start()
    {
        splight = GetComponent<Light>();
        nav = GetComponent<NavMeshAgent>();
        dazed = GameObject.FindWithTag("Stunned");
        dazed.gameObject.SetActive(false);
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

        if (stunned == true)
        {
            //start the timer for the stun 
            stun += Time.deltaTime;
            //stun for 3 seconds (greater than 3 seconds resumes movement)
            if (stun < 3f)
            {
                //turn on the stun game object with the collider
                dazed.gameObject.SetActive(true);
                //stop the navigation of the object
                nav.Stop();

            }
            else
            {
                //turn off the stun game object so it doesn't hit anything else
                dazed.gameObject.SetActive(false);
                //set stun back to false
                stunned = false;
                //reset the stun timer
                stun = 0;
                //continue navigating
                nav.Resume();

            }

        }
    }

    void OnTriggerEnter(Collider other)
    {
        //if something with the tag Stun collides with it then stunned = true;
        if (other.gameObject.CompareTag("Stunned"))
        {
            Debug.Log("Stunned");
            stunned = true;
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
    
