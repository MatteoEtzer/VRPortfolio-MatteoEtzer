using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    RaycastHit hit;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1000f))
            {
                Debug.Log("angeclickt");
            }
        }
    }
}
