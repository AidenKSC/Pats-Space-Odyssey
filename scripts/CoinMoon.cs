using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinMoon : MonoBehaviour
{
  private int count;
  public Text countText;
  public AudioSource Sound;
  public GameObject Axe;
  //public GameObject Rover;
    // Start is called before the first frame update
    void Start()
    {
      count=0;
      countText.text = "Coins: " + count.ToString();
      Axe = GameObject.FindWithTag ("PickAxe");
      Axe.gameObject.SetActive (false);
      //Rover = GameObject.FindWithTag ("Rover");
    //  Rover.gameObject.SetActive (false);

    }

    // Update is called once per frame
  void Update (){
        Sound = GetComponent<AudioSource>();
        axeCheck();
        //roverCheck();
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
     if (count >= 7){
       Axe.gameObject.SetActive (true);
     }
     else {
       Axe.gameObject.SetActive (false);
     }
   }
}
