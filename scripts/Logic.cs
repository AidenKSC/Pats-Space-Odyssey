using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{

    private InputField input;
    private InputField inputpass;

    public bool usernamecorrect = false;
    public bool passwordcorrect = false;

    public GameObject Granted;
    public GameObject Denied;
    public GameObject Enter;

    public AudioSource correctguess;
    public AudioSource wrongguess;
    public AudioSource shutdown;


     void Awake()
    {
        
    }

    // Start is called before the first frame update
    public void GetInput(string username)

    {
        if(username == "IHATEPAT")
        {

            Debug.Log("guessed right");
            usernamecorrect = true;
            
        }

        else
        {
            Debug.Log("guessed wrong");
            usernamecorrect = false;
        }
    }

    public void GetInputPass(string password)

    {
        if (password == "ILOVEPENNY")
        {

            Debug.Log("guessed right");
            passwordcorrect = true;
            correctguess.Play();
        }

        else
        {
            Debug.Log("guessed wrong");
            passwordcorrect = false;
            wrongguess.Play();
        }
    }

    public void check() //for login button
    {
        if(passwordcorrect == true && usernamecorrect == true)
        {
            Granted.SetActive(true);
            Enter.SetActive(true);
            Denied.SetActive(false);
        }

        else if(passwordcorrect == false && usernamecorrect == false)
        {
            Denied.SetActive(true);
            Enter.SetActive(false);
            Enter.SetActive(false);
        }
    }

    public void refresh()
    {
        Denied.SetActive(false);
        Granted.SetActive(false);
        Enter.SetActive(false);
        
    }

    public void Computer()
    {
        //use scene manager change;
    }

    public void CloseApplication()
    {
        SceneManager.LoadScene(16);
        shutdown.Play();
    }

    public void LoadScreen()
    {
        SceneManager.LoadScene(12);
    }


}
