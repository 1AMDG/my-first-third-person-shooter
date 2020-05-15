using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YCamera : MonoBehaviour {
    public float cameraSpeed = 100f;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        // if(Input.GetAxis("Mouse Y") < 0){
        //     transform.Rotate(camSpeed * Time.deltaTime, 0f, 0f);
        // }
        // else if(Input.GetAxis("Mouse Y") > 0){
        //     transform.Rotate(-camSpeed * Time.deltaTime, 0f, 0f);
        if (Input.GetAxis ("Mouse Y") > 0) {
            Vector3 rotateCam = new Vector3 (1, 0, 0);
            transform.Rotate (rotateCam * -cameraSpeed * Time.deltaTime);
        } else if (Input.GetAxis ("Mouse Y") < 0) {
            Vector3 rotateCam = new Vector3 (1, 0, 0);
            transform.Rotate (rotateCam * cameraSpeed * Time.deltaTime);
        }
    }
}