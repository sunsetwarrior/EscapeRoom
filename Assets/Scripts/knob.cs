using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

[RequireComponent(typeof(PhotonView))]
public class knob : Photon.MonoBehaviour
{

    public GameObject knobTarget;

    public void Start()
    {
        knobTarget.GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
    }

    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        Debug.Log("grabbed");

        if (this.photonView.ownerId == PhotonNetwork.player.ID)
        {
            return;
        }
        this.photonView.RequestOwnership();
    }
}
