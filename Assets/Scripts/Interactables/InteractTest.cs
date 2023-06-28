using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTest : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        //chucks something in the log if the object has been interacted
        Debug.Log(Random.Range(0, 100));
    }
}
