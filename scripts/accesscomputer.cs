using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class accesscomputer : MonoBehaviour
{

    public GameObject Enter;

    

    public void OnTriggerStay(Collider other)
    {
        Enter.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            
           
            SceneManager.LoadScene(11);
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        Enter.SetActive(false);
    }
}
