using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketShootMars : MonoBehaviour
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

    float timeToLoadScene = 5f;


  
    
    // Update is called once per frame
    void Update()
    {
      Sound = GetComponent<AudioSource>();
        if (Input.GetKeyDown(KeyCode.M))
        {
             gameObject.GetComponent<ConstantForce>().force = Vector3.up * 50;
            pat.SetActive( false);
            patcam.SetActive(false);
            rocketcam.SetActive(true);
            Sound.Play();

            Invoke("GoToScene",timeToLoadScene);
      
        }
    }

    void GoToScene()
    {
      SceneManager.LoadScene(10);
    }
}
