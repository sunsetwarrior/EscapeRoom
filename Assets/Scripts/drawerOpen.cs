using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Valve.VR;
public class drawerOpen : MonoBehaviour {

	//VR
//	private SteamVR_Controller.Device controller {get {  return SteamVR_Controller.Input ((int)trackedObj.index); }}
//	private SteamVR_TrackedObject trackedObj;
//	private Valve.VR.EVRButtonId hairTrigger = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
//	public bool hairTriggerDown = false;


	Animator animator;
	public AudioClip ac;
	bool isOpen = false;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
		//trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}


	// Update is called once per frame
	void Update () {
		//hairTriggerDown = controller.GetHairTriggerDown ();

		if(Input.GetKeyDown("space")){
			isOpen = !isOpen;
			animator.SetBool ("open", isOpen);
			AudioSource.PlayClipAtPoint (ac, gameObject.transform.position);
		}

//		if (hairTriggerDown) {
//			print ("hair trigger down");
//		}
	}

	void todo(){
		//http://escaperoom.net/play-17-CRIMSON-ROOM.html

	}
}
