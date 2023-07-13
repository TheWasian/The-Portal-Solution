using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger25 : MonoBehaviour
{
    public static bool exitTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HeavyCube"))
        {

            exitTrigger = true;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HeavyCube"))
        {

            exitTrigger = false;

        }
    }
}
