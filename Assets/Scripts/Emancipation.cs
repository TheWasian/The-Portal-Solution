using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emancipation : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //If object touches the empancipation grid the object will be destroyed
        if (other.CompareTag("Emancipation"))
        {
            Destroy(gameObject);
        }
    }
}
