using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class main_character : MonoBehaviour {

	// variables for character
	float dirX, dirY; // rotate character

	[SerializeField]
	float moveSpeed = 2f;



	/* GUN
	float rotateAngle; // rotate gun

	[SerializeField]
	float bulletSpeed = 5f;
	*/

	Animator anim;

	/*
	// Animator variable to control transitions
	[SerializeField]
	Transform gun;
	[SerializeField]
	Rigidbody2D bullet;
	*/


	// Start is called before the first frame update
    void Start()
    {
        //rotateAngle = 0f;
        anim = GetComponent<Animator> ();
        anim.speed = 1;
    }

	
    // Update is called once per frame
    void Update()
    {
        Move ();
        //Fire ();
        Rotate ();
    }

    void Move()
    {
    	dirX = Mathf.RoundToInt(CrossPlatformInputManager.GetAxis ("Horizontal"));
    	dirY = Mathf.RoundToInt(CrossPlatformInputManager.GetAxis ("Vertical"));

    	transform.position = new Vector2 (dirX * moveSpeed * Time.deltaTime + transform.position.x,
    		dirY * moveSpeed * Time.deltaTime + transform.position.y);
    }

    /*
    void Fire()
    {
    	if (CrossPlatformInputManager.GetButtonDown ("Fire1")) {
    		var firedBullet = Instantiate (bullet, gun.position, gun.rotation);
    		firedBullet.AddForce (gun.up * bulletSpeed);
    	}
    }
    */

    // animation control and gun rotation happens here
    void Rotate()
    {
    	// up
    	if (dirX == 0 && dirY == 1) {
    		//rotateAngle = 0;
    		anim.speed = 1;
    		anim.SetInteger ("Direction", 1);
    	}

    	/* 8-dir up-right
    	if (dirX == 1 && dirY == 1) {
    		//rotateAngle = -45f;
    		anim.speed = 1;
    		anim.SetInteger ("Direction", 2);
    	}
    	*/

    	// right
    	if (dirX == 1 && dirY == 0) {
    		//rotateAngle = -90f;
    		anim.speed = 1;
    		anim.SetInteger ("Direction", 2);
    	}

    	/* 8-dir down-right
    	if (dirX == 1 && dirY == -1) {
    		//rotateAngle = -135f;
    		anim.speed = 1;
    		anim.SetInteger ("Direction", 4);
    	}
    	*/

    	// down
    	if (dirX == 0 && dirY == -1) {
    		//rotateAngle = -180f;
    		anim.speed = 1;
    		anim.SetInteger ("Direction", 3);
    	}

    	/* 8-dir down-left
    	if (dirX == -1 && dirY == -1) {
    		//rotateAngle = -225f;
    		anim.speed = 1;
    		anim.SetInteger ("Direction", 6);
    	}
    	*/
    	
    	// left
    	if (dirX == -1 && dirY == 0) {
    		//rotateAngle = -270f;
    		anim.speed = 1;
    		anim.SetInteger ("Direction", 4);
    	}

    	/* 8-dir up-left
    	if (dirX == -1 && dirY == 1) {
    		//rotateAngle = -315f;
    		anim.speed = 1;
    		anim.SetInteger ("Direction", 8);
    	}
    	*/
    	
    	// idle
    	if (dirX == 0 && dirY == 0) {
    		anim.speed = 0;
    		anim.SetInteger ("Direction", 0);
    	}

    	// sets on an angle based according to character's direction
    	// gun.rotation = Quaternion.Euler (0f, 0f, rotateAngle);
    }

}
