using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectRightKey : MonoBehaviour {
	
	public GameObject rightObject;
	public GameObject boxRoof;
	public GameObject Door;
	private Color old;

	public GameObject stick;
	public GameObject ring1;
	public GameObject ring2;
	public static int num = 0;
	// Use this for initialization

	void Start () {
		old = rightObject.GetComponent<Renderer> ().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other){
		if(other.gameObject != rightObject){
			other.gameObject.GetComponent<Renderer> ().material.color = new Color (255,0,0);
		}
		num++;

		if (num == 3) {
			stick.SetActive (false);
			ring1.SetActive (false);
			ring2.SetActive (false);
			boxRoof.GetComponent<boxOpen> ().Open();
		}
		if(num == 5){
			//door open
			Door.GetComponent<boxOpen>().Open();
		}
	}

	private void OnTriggerExit(Collider other){
		if (other.gameObject != rightObject) {
			other.gameObject.GetComponent<Renderer> ().material.color = old;
		}
		num--;
	}
}
