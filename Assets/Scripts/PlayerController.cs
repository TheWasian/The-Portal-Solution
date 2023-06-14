using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PortalableObject
{
    private PlayerCam2 playerCam2;

    protected override void Awake()
    {
        base.Awake();

        playerCam2 = GetComponent<PlayerCam2>();
    }

    public override void Warp()
    {
        base.Warp();
        playerCam2.ResetTargetRotation();
    }
}
