using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour {

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButton(0)) {
            // RaycastHit hit;
            // Ray rayOrigin = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0f));
            // // Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            // // Physics.Raycast(rayOrigin.origin, forward, out hit, Mathf.Infinity);
            // // Debug.DrawRay(transform.position, hit.point, Color.green);
            // // if (Physics.Raycast(rayOrigin, out hit, Math.infinity))

            // Debug.Log(rayOrigin.origin);
            // if (Physics.Raycast (rayOrigin.origin, transform.TransformDirection (Vector3.forward), out hit, Mathf.Infinity)) {
            //     Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.forward) * hit.distance, Color.yellow);
            //     Debug.Log ("Did Hit");
            // } else {
            //     Debug.Log ("No hit.");
            // }

            Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5F, 0.5F, 0));
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit)) {
                print ("I'm looking at " + hit.transform.name);
                Debug.DrawRay(transform.position, ray.origin - transform.position, Color.yellow);
                // Debug.DrawRay(transform.position, hit.transform.position - transform.position, Color.yellow);
                Rigidbody enemyBody = hit.transform.gameObject.GetComponent<Rigidbody>();
                if (enemyBody != null) {
                    Vector3 unitDirectionOfEnemyFromMe = (hit.transform.position - transform.position).normalized;
                    enemyBody.AddForce (unitDirectionOfEnemyFromMe * 10f);
                }
            } else {
                print ("I'm looking at nothing!");
            }

        }
    }
}