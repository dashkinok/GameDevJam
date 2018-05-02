using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DialogueStateManager : MonoBehaviour {

	public Button yesButton;
	public Button noButton;

	public Image jealousy;

	public Text myText;
	public Text YesChoice;
	public Text NoChoice;

	private DialogueState _activeDialogueState;



	//on Start the FirstQustion is called/created from the DialogueState class
	//If yes or no button clicked, they call functions OnYes or OnNo
	void Start () {

		_activeDialogueState = new FirstQuestion();

		//calmModeImage = GetComponent<Image>();



		yesButton.onClick.AddListener (OnYes);
		noButton.onClick.AddListener (OnNo);
	}

	//If FirstQuestion is being refered to and is active then text of the question may change
	//done so by calling the DialogueState class, question string, allowing it to change the words
	//if a specific question is asked, then text of the yes/no button changes, if not the text goes to yes/no
	public void Update()
	{
		if (_activeDialogueState != null) {
			myText.text = _activeDialogueState.question;

		}
		if(_activeDialogueState.question == "I see you know your Greek mythology, or perhaps you like either DC or Marvel comics… Do you know what I punish people for?" ||
		   _activeDialogueState.question == "Erinyes are Goddesses of vengeance. And one of us WILL come for you if you decide to do something that may really upset one of us. Do you know what I will punish you for?" || 
		   _activeDialogueState.question == "Well, well… You are correct. Here’s a next question, do you know which one of us punishes people for their crimes, especially martial infidelity?"||
		   _activeDialogueState.question == "I will punish you for any murder you commit. Here’s a next question, do you know which one of us punishes people for their crimes, especially martial infidelity?" ||
		   _activeDialogueState.question == "Yes it is me, Megaera, watch out for me I am the jealous Fury, you don’t want to upset me with your unfaithfulness… Tell me, who punishes for moral crimes of humans, such as anger?" ||
		   _activeDialogueState.question == "Wow. No, Alecto doesn't know how to properly do that. I am Megaera. Also known as the Fury of Jealousy...You better not dissapoint me. EVER. Tell me, Tell me, who punishes for moral crimes of humans, such as anger?" ||
		   _activeDialogueState.question == "Watch out for your wrong-doings, I will bring torture into your life. Hi, I’m Alecto, unceasing in anger…Do you think you are willing to disappoint us?" ||
		   _activeDialogueState.question == "COME ON. She literally just told you that she punishes for murder. I am Alecto, your moral crimes won't go pass me...Do you think you are willing to disappoint us?" ||
		   _activeDialogueState.question == "I see your quite loyal. Next thing you know, that person charges at you and tell you that they want to be with you and no one else. They're quite aggressive. What do you do? ")
		{
			YesChoice.text = _activeDialogueState._yes;
			NoChoice.text = _activeDialogueState._no;
		}
		else{
			YesChoice.text = "Yes";
			NoChoice.text = "No";
		}

//		if(_activeDialogueState.question == "GAME OVER /n Do you want to try again?" ||
//			_activeDialogueState.question == "GAME OVER /n I told you. I will get to you. /n Do you want to try again?" ||
//			_activeDialogueState.question == "GAME OVER /n YOU ARE DISGUSTING! HOW COULD YOU! /n Do you want to try again?" ||
//			_activeDialogueState.question == "GAME OVER /n I hope you suffer... /n Do you want to try again?")
//		{
//			 Destroy(yesButton.gameObject);
//			 Destroy(noButton.gameObject);
//
//
//		}
	}

	//By calling the DialogueState class, and by connecting it to the dialoguestate yes, 
	public void OnYes()
	{
		_activeDialogueState = _activeDialogueState.yes;
	}
	//By calling the DialogueState class, and by connecting it to the dialoguestate no, 

	public void OnNo()
	{
		_activeDialogueState = _activeDialogueState.no;
	}
}
