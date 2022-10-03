using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShootSpace : MonoBehaviour
{
    Vector3 force;
    Vector3 relativeTorque;
    float liftSpeed;
    float turnSpeed;
    public GameObject gameObject;
    public GameObject pat;
    public GameObject patcam;
    public GameObject rocketcam;
    public AudioSource Sound;

    public GameObject PatRocket;
    public GameObject JudasRocket;
    public GameObject hearts;
    public GameObject stars;

    // Update is called once per frame
    void Update()
    {
      Sound = GetComponent<AudioSource>();
        if (Input.GetKeyDown(KeyCode.P))
        {
             gameObject.GetComponent<ConstantForce>().force = Vector3.up * 50;
            pat.SetActive( false);
            patcam.SetActive(false);
            rocketcam.SetActive(true);
            PatRocket.SetActive(true);
            JudasRocket.SetActive(true);
            hearts.SetActive(true);
            stars.SetActive(true);
            
            Sound.Play();

        }
    }
}
