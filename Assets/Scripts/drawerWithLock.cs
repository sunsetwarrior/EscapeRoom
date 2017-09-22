using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawerWithLock : MonoBehaviour {
	public GameObject text;
	public GameObject rightKey;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other){
		if (other != rightKey) {
			gameObject.GetComponent<TextMesh>().text = "You need a key";
		}
	}

	private void OnTriggerExit(Collider other){
		gameObject.GetComponent <TextMesh>().text = null;

	}
}
