using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneObject : Photon.MonoBehaviour {

    public GameObject bin;
    public GameObject door;
    public GameObject chest;
    public GameObject drawer;

	// Use this for initialization
	void Start () {
        PhotonNetwork.Instantiate(bin.name, bin.transform.position, bin.transform.rotation, 0);
        PhotonNetwork.Instantiate(door.name, door.transform.position, door.transform.rotation, 0);
        PhotonNetwork.Instantiate(chest.name, chest.transform.position, chest.transform.rotation, 0);
        PhotonNetwork.Instantiate(drawer.name, drawer.transform.position, drawer.transform.rotation, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
