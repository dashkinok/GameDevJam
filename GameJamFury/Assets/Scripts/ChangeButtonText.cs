using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;

public class ChangeButtonText : MonoBehaviour {

	private DialogueStateManager Buttonz;
	private DialogueState __activeDialogueState;

	public string myButtonText = " ";


	void Start(){
		__activeDialogueState = new WhoErinyesYes ();
	}

	void onGUI () {
		if (__activeDialogueState != null) {
			Debug.Log("helloqeqwe");

			myButtonText = "Deadakbj";
		
		} 
	}
}
