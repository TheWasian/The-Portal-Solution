using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttontrigger : MonoBehaviour
{
    public static bool exitTrigger = false;

    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("HeavyCube"))
            {

                exitTrigger = true;

            }

            if (!(other.CompareTag("HeavyCube")))
            {

                exitTrigger = false;

            }
    }
    


}
