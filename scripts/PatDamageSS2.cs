namespace Dypsloom.DypThePenguin.Scripts.Damage
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class PatDamageSS2 : MonoBehaviour
{
        public GameObject Pat;
        public int health;
        public int maxHealth = 60;
        public HealthBar healthBar;

        public AudioSource HealSound;
        [SerializeField] protected ParticleSystem m_Effect;
        [SerializeField] protected Animator m_Animator;

        void Start()
        {
            health = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }


        void Update()
           {
            KillPat();
           }

           private void OnTriggerEnter(Collider other)
           {
             if (other.gameObject.tag == "Enemy"){
                health = health - 10;
                print(health);
             }
             if (other.gameObject.tag == "Lava"){
                health = health - 100;
                print(health);
              }

              if (other.gameObject.tag == "fire"){
                 health = health - 15;
                 print(health);
               }
              if (other.gameObject.tag == "eSnowBall"){
                   health = health - 15;
                   print(health);
                 }

            if (other.gameObject.tag == "Coin" && health < 60)
            {
                health = health + 6;
                print(health);
                m_Effect.Play();
                HealSound.Play();
            }

            healthBar.SetHealth(health);

        }


           public void KillPat()
           {
              if(health < 0)
            {
                Destroy(Pat);
                SceneManager.LoadScene(16);
            }
           }

}
}
