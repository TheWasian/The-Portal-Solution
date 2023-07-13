using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dispensertrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            dispenserLogic.dTrigger = true;
            
        }
    }
}
   
