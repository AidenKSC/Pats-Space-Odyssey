using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class penguincolumn : MonoBehaviour
{
 private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<Penguin> () != null)
            {
            PenguinConfig.inst.PenguinScored();
        }
    }
}
