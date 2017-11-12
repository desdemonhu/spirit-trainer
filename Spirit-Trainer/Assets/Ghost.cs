using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {

    Rigidbody rigidBody;
    AudioSource thrusters;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        thrusters = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!thrusters.isPlaying)
            {
                thrusters.Play();
            }
            
        } else
        {
            thrusters.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            print(Vector3.forward);
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D)){
            transform.Rotate(-Vector3.forward);
        }
    }
}
