using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    public Animator anim;


    private void Update()
    {
        if (buttontrigger.exitTrigger == true)
        {
            anim.SetBool("pressed", true);
        }
    }
}
