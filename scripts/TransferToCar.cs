using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferToCar : MonoBehaviour
{

    public GameObject gameObject;
    public GameObject pat;
    public GameObject patcam;
    public GameObject CarCam;
    public GameObject getIn;
    public GameObject getOff;

   

    // Update is called once per frame

    private void Start()
    {
     CarCam.SetActive(false);
     
    }
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.K))
        {
            pat.SetActive( false);
            patcam.SetActive(false);
            CarCam.SetActive(true);
            gameObject.GetComponent<Car_Move>().enabled = true;

            pat.transform.position = getIn.transform.position ;

        }
         if (Input.GetKeyDown(KeyCode.J))
        {
            pat.SetActive( true);
            patcam.SetActive(true);
            CarCam.SetActive(false);
            gameObject.GetComponent<Car_Move>().enabled = false;
            pat.transform.position = getOff.transform.position ;

        }
    }
}
