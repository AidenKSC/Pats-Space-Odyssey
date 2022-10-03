using UnityEngine;
using System.Collections;


public class EnterVehicle : MonoBehaviour
{
    private bool inVehicle = false;
    Car_Move vehicleScript;
    GameObject Pat;


    void Start()
    {
        vehicleScript = GetComponent<Car_Move>();
        Pat = GameObject.FindWithTag("Player");
       
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && inVehicle == false)
        {
           
            if (Input.GetKey(KeyCode.E))
            {
               
                Pat.transform.parent = gameObject.transform;              
                vehicleScript.enabled = true;
                Pat.SetActive(false);
                inVehicle = true;
            }
        }
    }
 
    void Update()
    {
        if (inVehicle == true && Input.GetKey(KeyCode.F))
        {
            vehicleScript.enabled = false;
            Pat.SetActive(true);
            Pat.transform.parent = null;
            inVehicle = false;
        }
    }
    
    }