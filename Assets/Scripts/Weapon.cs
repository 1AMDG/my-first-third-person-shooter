using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Cursor.visible = true;
            GameObject Capsule = GameObject.Find("Capsule");
            Capsule.GetComponent<CameraRotate>().enabled = false;
            GameObject camholder = GameObject.Find("camholder");
            camholder.GetComponent<YCamera>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
        if(Input.GetKeyUp(KeyCode.Escape)){
            Cursor.visible = false;
            GameObject Capsule = GameObject.Find("Capsule");
            Capsule.GetComponent<CameraRotate>().enabled = true;
            GameObject camholder = GameObject.Find("camholder");
            camholder.GetComponent<YCamera>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }
        }
    }
