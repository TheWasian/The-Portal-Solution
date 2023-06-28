using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDetect : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        //checks if the object touches "Heavy Button"
        if (other.CompareTag("HeavyButton"))
        {
            //Runs animation for door
            Debug.Log("Touched");
            anim.SetBool("near", true);
        }
        else
        {
            anim.SetBool("near", false);
        }
    }
}
