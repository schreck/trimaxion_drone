﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dronecontrol : MonoBehaviour {

    private Vector3 v; // velocity (m/s)
    private Vector3 left_throttle_position; // xlate
    private Vector3 right_throttle_position; // xlate

    private Transform port_rig;
    private Vector3 port_zero;
    private Transform starboard_rig;
    private Vector3 starboard_zero;
                                            
    // Use this for initialization
    void Start () {
        v = Vector3.zero;
        port_rig = transform.Find("port rig").gameObject.transform;
        port_zero = port_rig.position;
        starboard_rig = transform.Find("starboard rig").gameObject.transform;
        starboard_zero = starboard_rig.position;
    }

    void FixedUpdate()
    {

    }
	
	// Update is called once per frame
	void Update () {
        left_throttle_position = Vector3.zero;
        right_throttle_position = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            left_throttle_position += new Vector3(0f, 0f, .5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            left_throttle_position += new Vector3(0f, 0f, -.5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            left_throttle_position += new Vector3(-.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            left_throttle_position += new Vector3(.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.I))
        {
            right_throttle_position += new Vector3(0f, 0f, .5f);
        }
        if (Input.GetKey(KeyCode.K))
        {
            right_throttle_position += new Vector3(0f, 0f, -.5f);
        }
        if (Input.GetKey(KeyCode.J))
        {
            right_throttle_position += new Vector3(-.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.L))
        {
            right_throttle_position += new Vector3(.5f, 0f, 0f);
        }
        port_rig.position = port_zero + right_throttle_position;
        starboard_rig.position = starboard_zero + left_throttle_position;
	}
}
