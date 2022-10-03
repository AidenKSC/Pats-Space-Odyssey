using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamLauncher : MonoBehaviour
{
   
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Player")
        {
            player.transform.parent = transform;
        }


    }

    void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }
}
