using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTestScript : MonoBehaviour
{
    public Animator anim;
    public Transform player;
    public Transform door;
    public float range;

    private void Update()
    {
        float distance = Vector3.Distance(player.position, door.position);

        if(distance <= range)
        {
            anim.SetBool("near", true);
        }
        else
        {
            anim.SetBool("near", false);
        }

    }
}
