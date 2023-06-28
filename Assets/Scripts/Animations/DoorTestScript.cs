using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTestScript : MonoBehaviour
{
    // creates variables I can edit in the unity GUI
    public Animator anim;
    public Transform player;
    public Transform door;
    public float range;

    private void Update()
    {
        //calculates player distance from door
        float distance = Vector3.Distance(player.position, door.position);

        if(distance <= range)
        {
            //activates door if player is near door
            anim.SetBool("near", true);
        }
        else
        {
            anim.SetBool("near", false);
        }

    }
}
