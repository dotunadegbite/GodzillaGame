using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    public float moveForce = 5, boostMultiplier = 2;

	// Use this for initialization
	void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 movementVector = new Vector3 (CrossPlatformInputManager.GetAxis("Horizontal"), 1, CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
        bool isBoosting = CrossPlatformInputManager.GetButton("Boost");

        rb.AddForce(movementVector * (isBoosting ? boostMultiplier : 1));
	}
}
