using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emancipation : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Emancipation"))
        {
            Destroy(gameObject);
        }
    }
}
