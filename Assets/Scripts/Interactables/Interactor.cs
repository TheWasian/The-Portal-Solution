using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable
{
    public void Interact();
}


public class Interactor : MonoBehaviour
{

    public Transform interactorSource;
    public float interactRange;
   
    void Update()
    {
        //Calculates if the player is near
        if (Input.GetKeyDown(KeyCode.E))
        {
            //shoots reycast to test if the player is close enough to interact with the object
            Ray r = new Ray(interactorSource.position, interactorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, interactRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }
}
