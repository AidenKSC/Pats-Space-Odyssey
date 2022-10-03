using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

  public float lookRadius = 10f;
  Transform target;
  NavMeshAgent agent;
  public AudioSource Sound;
//  public float moveSpeed;

    void Start()
    {
      target = PlayerManager.instance.player.transform;
      agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
      Sound = GetComponent<AudioSource>();
      float distance = Vector3.Distance(target.position, transform.position);

      //if (distance >= lookRadius){
       // agent.SetDestination(target.position);
        //Sound.Play(); //commented out as was filling the command line with errors making hard to test anything. Needs a sound in the inspector to work

       if (distance <= lookRadius){
        agent.SetDestination(target.position);
        //Sound.Play();

        if( distance <= agent.stoppingDistance){
          FaceTarget();
        }
          // else {
          //
          //   Sound.Stop();
          //   // need to get the alien to remain stationary too...
          // }


}
      //}
    }

    void FaceTarget(){
      Vector3 direction = (target.position - transform.position).normalized;
      Quaternion LookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
      transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, Time.deltaTime * 5f);
    }


    void OnDrawGizmosSelected (){
      Gizmos.color = Color.red;
      Gizmos.DrawWireSphere(transform.position, lookRadius);
    }



}
