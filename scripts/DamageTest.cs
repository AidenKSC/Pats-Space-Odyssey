using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
  float damage = -1f;

  void OnTriggerEnter(Collider other)
  {
              if (other.gameObject.tag == "Player" )
              {
                      //Damage d = other.GameObject.GetComponent<Damage>(); //commented out to fix error for now :)
                      // d.AdjustCurrentHealth(damage);

              Destroy(this.gameObject);
            }

  }
}
