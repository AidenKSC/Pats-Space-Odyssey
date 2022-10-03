using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5; //change health
    public int currentHealth;
    public AudioSource dieSound;
    public AudioSource hurt;
    public HealthBar healthBar;
    
    


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


   //place holder, change to (if touch object, then lose health)
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace)) 
        {
            TakeDamage(1);
            
            
        }
        if (currentHealth <= 0)
        {
            dieSound.Play();
            SceneManager.LoadScene(2);
        }

        

      

        

        //Player dies if you character fell off the platform, still need to work on this
        //  if(player.position.y < -10)
        // {
        //     TakeDamage(5);
        // }
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void CollectHealth()
    {
        if (currentHealth < maxHealth)
        {
            currentHealth++;
            healthBar.SetHealth(currentHealth);
        }
    }

    

   
}
