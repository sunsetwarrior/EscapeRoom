using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOpen : MonoBehaviour {
	bool isOpen = false;
	public GameObject light1;
	public GameObject light2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("0")) {
			isOpen = !isOpen;
			light1.SetActive (isOpen);
			light2.SetActive (isOpen);
		}
	}
}
