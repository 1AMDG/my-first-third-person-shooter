﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float playerForce = 60f;
    public Rigidbody rigidPlayer;
    public float rotateSpeed = 2f;
    public float cameraRotate = 200f;
    // Start is called before the first frame update
    void Start () {
        rigidPlayer = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update () {
        

        Vector3 allMoves = transform.position;
        
        // if (Input.GetKeyDown (KeyCode.A)) {
        //     // rigidPlayer.MoveRotation(new Vector3(0,-90f,0));
        //     // transform.rotation += new Vector3(0,-90f,0);
        //     // transform.LookAt(Vector3.left);
        //     // print ("LOOKLEFT");

        // }   

        if (Input.GetKey (KeyCode.A)) {
            // allMoves = allMoves + (transform.forward * playerForce * Time.deltaTime);
            allMoves = allMoves + (-transform.right * playerForce * Time.deltaTime);
            // print ("A");
        }
        if (Input.GetKey (KeyCode.W)) {
            allMoves = allMoves + (transform.forward * playerForce * Time.deltaTime);
            // print ("W");
        }
        if (Input.GetKey (KeyCode.D)) {
            allMoves = allMoves + (transform.right * playerForce * Time.deltaTime);
            // print ("D");
        }
        if (Input.GetKey (KeyCode.S)) {
            allMoves = allMoves + (-transform.forward * playerForce * Time.deltaTime);
            // print ("S");
        }

        rigidPlayer.MovePosition (allMoves);
        // allMoves = transform.TransformPoint (allMoves);

        if (Input.GetKeyDown ("space")) {
            rigidPlayer.AddForce (transform.up * 100f);
        }
        

    }
}