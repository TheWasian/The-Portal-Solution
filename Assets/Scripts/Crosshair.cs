using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    [SerializeField]
    private PortalPair portalPair;

    [SerializeField]
    private Image inPortalImg;

    [SerializeField]
    private Image outPortalImg;

    private void Start()
    {
        // Checks if the portals exists
        var portals = portalPair.Portals;

        //Changes the colour of the crosshair to match the colour of the portals
        inPortalImg.color = portals[0].PortalColour;
        outPortalImg.color = portals[1].PortalColour;
        //Ensures that the crosshair will be disabled 
        inPortalImg.gameObject.SetActive(false);
        outPortalImg.gameObject.SetActive(false);
    }

    public void SetPortalPlaced(int portalID, bool isPlaced)
    {
        if(portalID == 0)
        {
            inPortalImg.gameObject.SetActive(isPlaced);
        }
        else
        {
            outPortalImg.gameObject.SetActive(isPlaced);
        }
    }
}
