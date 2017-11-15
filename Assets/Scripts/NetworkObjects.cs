using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class NetworkObjects : Photon.MonoBehaviour {

	void Update () {

        if (this.photonView.ownerId == PhotonNetwork.player.ID)
        {
            return;
        }

        if (this.GetComponent<VRTK_InteractableObject>() != null && this.GetComponent<VRTK_InteractableObject>().IsGrabbed())
        {
            Debug.Log("grabbed......................................................");
            this.photonView.RequestOwnership();
        }
    }
}
