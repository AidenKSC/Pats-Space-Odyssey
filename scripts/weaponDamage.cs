using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponDamage : MonoBehaviour
{
    int damage = -10;
    // Start is called before the first frame update
    void Start()
    {
        //float damage = -10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyHealth eHealth = other.gameObject.GetComponent<enemyHealth>();
            eHealth.AdjustCurrentHealth(damage);
        }
        if (other.gameObject.tag == "Astro")
        {
            enemyHealth eHealth = other.gameObject.GetComponent<enemyHealth>();
            eHealth.AdjustCurrentHealth(damage);
        }
        Destroy(this.gameObject);
    }
}
