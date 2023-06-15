using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDetect : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HeavyButton"))
        {
            Debug.Log("Touched");
            anim.SetBool("near", true);
        }
        else
        {
            anim.SetBool("near", false);
        }
    }
}
