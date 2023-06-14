using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGun : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float maxGrabDistance = 10f;
    [SerializeField] Transform objectHolder;

    Rigidbody grabbedRB;


    void Start()
    {
        
    }

    
    void Update()
    {
        if(grabbedRB)
        {
            grabbedRB.MovePosition(objectHolder.transform.position); 
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (grabbedRB)
            {
                // if E is hit again while holding an object the object will drop
                grabbedRB.isKinematic = false;
                grabbedRB = null;
            }
            else
            {
                //detects if game object is infront
                RaycastHit hit;
                Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                if(Physics.Raycast(ray, out hit, maxGrabDistance))
                {
                    grabbedRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if (grabbedRB)
                    {
                        grabbedRB.isKinematic = true;
                    }
                }
            }
        }
    }
}
