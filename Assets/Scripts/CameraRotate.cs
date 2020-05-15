using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
    public float cameraRotate = 200f;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void LateUpdate () {
        if (Input.GetAxisRaw ("Mouse X") > 0) {
            transform.Rotate (0f, cameraRotate * Time.deltaTime, 0f);
        }
        if (Input.GetAxisRaw ("Mouse X") < 0) {
            transform.Rotate (0f, -cameraRotate * Time.deltaTime, 0f);
        }
        // if (Input.GetAxis ("Mouse Y") > 0) {
        //     Vector3 rotateCam = new Vector3 (1, 0, 0);
        //     transform.Rotate (rotateCam * -cameraRotate * Time.deltaTime);
        // } else if (Input.GetAxis ("Mouse Y") < 0) {
        //     Vector3 rotateCam = new Vector3 (1, 0, 0);
        //     transform.Rotate (rotateCam * cameraRotate * Time.deltaTime);
        // }
    }
}