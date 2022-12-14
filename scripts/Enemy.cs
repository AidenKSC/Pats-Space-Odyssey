using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

  private Transform player;
  private float dist;
  public float moveSpeed;
  public float howClose;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Pat").transform;
    }


    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);
        howClose = 10;
        if (dist <= howClose)
        {
          transform.LookAt(player);
          GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
        }
    }
}
