using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class NetworkObjects : MonoBehaviour {

    public GameObject spawn;
	// Use this for initialization
	void Start () {
        spawn.transform.position = this.transform.position;
        spawn.transform.rotation = this.transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        if (this.GetComponent<VRTK_InteractableObject>().IsGrabbed())
        {
            print("grabbed");
            gameObject.SetActive(false);
            GameObject newObject = PhotonNetwork.Instantiate(this.name, spawn.transform.position, spawn.transform.rotation, 0);
            newObject.GetComponent<NetworkObjects>().enabled = false;
            Destroy(gameObject);
        }
	}

    public void Controlled() {
        print("moved");
    }
}
