using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFollow : MonoBehaviour {


    public Transform target;
    public Vector3 offset;

    public float smoothSpeed = 0.125f;

    //void LateUpdate () 
    void FixedUpdate ()
    {

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }



/*
    // camera following player
    private Vector3 _cameraOffset;
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;


	// Start is called before the first frame update
    void Start()
    {
        // difference between camera and player position
        _cameraOffset = transform.position - PlayerTransform.position;

    }

	
    // Update is called once per frame
    void Update()
    {

        Vector newPos = PlayerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

    }

    */

}
