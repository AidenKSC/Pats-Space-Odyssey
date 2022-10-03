using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerMars : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(10);
    }
   // space station = 6
   // mars = 5
   // neptune = 4
    // moon = 3
    // start menu = 2
    // earth = 1
}
