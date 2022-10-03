using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Folders : MonoBehaviour
{

    public GameObject Diary;
    public GameObject Pin;
    public GameObject xo;
    public GameObject pic2;

    public GameObject closeDiary;
    public GameObject closePin;
    public GameObject closexo;

    public AudioSource Shutdown;


   

  public void DiaryOpen()
    {
        Diary.SetActive(true);
        Pin.SetActive(false);
        xo.SetActive(false);
        pic2.SetActive(false);

        closeDiary.SetActive(true);
        closePin.SetActive(false);
        closexo.SetActive(false);
    }

    public void PinOpen()
    {
        Diary.SetActive(false);
        Pin.SetActive(true);
        xo.SetActive(false);
        pic2.SetActive(false);

        closeDiary.SetActive(false);
        closePin.SetActive(true);
        closexo.SetActive(false);
    }

    public void xoOpen()
    {
        Diary.SetActive(false);
        Pin.SetActive(false);
        xo.SetActive(true);
        pic2.SetActive(true);

        closeDiary.SetActive(false);
        closePin.SetActive(false);
        closexo.SetActive(true);
    }

    public void Close()
    {
        Diary.SetActive(false);
        Pin.SetActive(false);
        xo.SetActive(false);
        pic2.SetActive(false);

        closeDiary.SetActive(false);
        closePin.SetActive(false);
        closexo.SetActive(false);

    }

    public void LoadVideo()
    {
        SceneManager.LoadScene(13);
    }

    public void ExitComputer()
    {
        SceneManager.LoadScene(16);
        Shutdown.Play();
    }

    public void LoadComputer()
    {
        SceneManager.LoadScene(12);
    }


}
