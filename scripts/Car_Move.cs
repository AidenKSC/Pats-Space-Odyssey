using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterController = UnityEngine.CharacterController;

public class Car_Move : MonoBehaviour
{
 

   
    private float speed = 50.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;

    public Rigidbody rb;
    
 


  private void Start()
  {
     this.enabled = false;
  }
  private void Awake()
  {
    rb = GetComponent<Rigidbody>();  
  }


  public void FixedUpdate()
  {
  GetComponent<Rigidbody>().AddForce(Physics.gravity * 15f, ForceMode.Acceleration);
  }

    private void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
          forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
          transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
       
          }
    }


 

