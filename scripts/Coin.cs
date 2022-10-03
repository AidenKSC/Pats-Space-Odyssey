using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

  private int count;
  public Text countText;
  public AudioSource Sound;
  public GameObject Axe;
  public GameObject Rover;
  public GameObject Jack;
    // Start is called before the first frame update
    void Start()
    {
      count=0;
      countText.text = "Coins: " + count.ToString();
      Axe = GameObject.FindWithTag ("PickAxe");
      Axe.gameObject.SetActive (false);

      Rover = GameObject.FindWithTag ("Car");
      Rover.gameObject.SetActive (false);

       //Jack = GameObject.FindWithTag("Jack");
      // Jack.gameObject.SetActive (false);

      // Jack = gameObject.Find("Jack");
      // Jack.setActive(false);

    }

    // Update is called once per frame
      public void Update (){
        Sound = GetComponent<AudioSource>();
        axeCheck();
        roverCheck();
        removeJack();
    }


    void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.CompareTag ("Coin"))
       {
           other.gameObject.SetActive (false);
           count  = count +1;
           countText.text = "Coins: " + count.ToString();
           Sound.Play();
       }
   }

   void axeCheck(){
    // Axe = GameObject.FindWithTag ("PickAxe");
    Axe.gameObject.CompareTag ("PickAxe");
     if (count >= 10){
       Axe.gameObject.SetActive (true);
     }
     else {
       Axe.gameObject.SetActive (false);
     }
   }

   void roverCheck(){
    Rover.gameObject.CompareTag ("Car");
     if (count >= 1){
       Rover.gameObject.SetActive (true);
     }
     else {
       Rover.gameObject.SetActive (false);
     }
   }

    public void removeJack()
    {
        if (count == 2)
        {
            Jack.SetActive(false);
        }
    }

   // void jackCheck(){
   //   Jack.gameObject.CompareTag ("Jack");
   //    if (count >= 1){
   //      Jack.gameObject.SetActive (false);
   //    }
   //    else {
   //      Jack.gameObject.SetActive (true);
   //    }
   // }
}
