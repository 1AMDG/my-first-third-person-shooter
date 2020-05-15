using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0)){
        RaycastHit hit;
        Ray rayOrigin = Camera.main.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0.5f));

        // if (Physics.Raycast(rayOrigin, out hit, ))
        
    }
}
}