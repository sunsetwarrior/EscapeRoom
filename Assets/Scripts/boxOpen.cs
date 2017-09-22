using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxOpen : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}

	public void Open(){
		animator.SetBool ("open", true);
	}
}
