using Dypsloom.DypThePenguin.Scripts.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenusButtons : MonoBehaviour
{
    public Character duh;

    public void Credits()
    {
        SceneManager.LoadScene(7);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("Quitting Game");
        Application.Quit();

    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Resume()
    {
        //not sure yet
    }

    public void LoadBirdFlight()
    {
        SceneManager.LoadScene(2);
    }


    public void LoadEarth()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMoon()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadMars()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadNeptune()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadStation()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadSpace()
    {
        SceneManager.LoadScene(10);
    }

    public void LoadResume()
    {
        SceneManager.LoadScene(14);
    }

    public void LoadGuide()
    {
        SceneManager.LoadScene(15);
    }
}
