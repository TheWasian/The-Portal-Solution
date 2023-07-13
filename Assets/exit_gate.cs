using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_gate : MonoBehaviour
{
    public Animator anim;


    private void Update()
    {
        if(buttontrigger.exitTrigger == true)
        {
            
            anim.SetBool("near", true);
        }
    }
}
