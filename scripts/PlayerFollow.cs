using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{

    public Transform PlayerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;



    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if (RotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);


            _cameraOffset = camTurnAngle * _cameraOffset;


          
        }
        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (RotateAroundPlayer) 
            transform.LookAt(PlayerTransform);
    }
}
