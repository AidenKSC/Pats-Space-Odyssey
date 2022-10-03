using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageLink : MonoBehaviour
{
  float damage = -1f;

  void OnTriggerEnter(Collider other)
  {
              if (other.gameObject.tag == "Enemy" )
              {
                     // Damage d = other.GameObject.GetComponent<Damage>(); commented out to fix error for now :)
                     //  d.AdjustCurrentHealth(damage);
              }
              Destroy(this.gameObject);

  }
}
