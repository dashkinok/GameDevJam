using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DialogueState {
	public string question;
	public DialogueState yes;
	public string _yes;
	public DialogueState no;
	public string _no;
	public DialogueState jealousy;

}

public class FirstQuestion : DialogueState
{
	public FirstQuestion()
	{
		question = "Is it okay to seek revenge?";
		yes = new YesToRevenge();
		no = new GameOverState();
//		jealousy.enabled = true;
//		sprite = new Sprite();
	}
}

public class YesToRevenge : DialogueState
{
	public YesToRevenge()
	{
		question = "Very well. Do you know who I am?";
		yes = new DoYouKnowWhoIAmYes();
		no = new DoYouKnowWhoIAmNo();
	}
}
	

public class DoYouKnowWhoIAmYes: DialogueState
{
	public DoYouKnowWhoIAmYes()
	{
		question = "Yes I am Tisiphone, one of three Erinyes. Do you know who Erinyes are?";
		yes = new WhoErinyesYes();
		no = new WhoErinyesNo();
	}
}
	
public class DoYouKnowWhoIAmNo: DialogueState
{
	public DoYouKnowWhoIAmNo()
	{
		question = "I am Tisiphone, one of three Erinyes also known as Furies. Do you know who Erinyes are?";
		yes = new WhoErinyesYes();
		no = new WhoErinyesNo();
	}
}

public class WhoErinyesYes: DialogueState
{
	public WhoErinyesYes()
	{
		question = "I see you know your Greek mythology, or perhaps you like either DC or Marvel comics… Do you know what I punish people for?";
		yes = new TisiphonePunishYes();
		_yes = "Murder";
		_no = "Moral crimes";
		no = new TisiphonePunishNo();
	}
}

public class WhoErinyesNo: DialogueState
{
	public WhoErinyesNo()
	{
		question = "Erinyes are Goddesses of vengeance. And one of us WILL come for you if you decide to do something that may really upset one of us. Do you know what I will punish you for?";
		yes = new TisiphonePunishYes();
		_yes = "Murder";
		_no = "Moral crimes";
		no = new TisiphonePunishNo();
	}
}

public class TisiphonePunishYes: DialogueState
{
	public TisiphonePunishYes()
	{
		question = "Well, well… You are correct. Here’s a next question, do you know which one of us punishes people for their crimes, especially martial infidelity?";
		yes = new MegaeraPunishYes();
		_yes = "Megaera";
		_no = "Alecto";
		no = new MegaeraPunishNo();
	}
}

public class TisiphonePunishNo: DialogueState
{
	public TisiphonePunishNo()
	{
		question = "I will punish you for any murder you commit. Here’s a next question, do you know which one of us punishes people for their crimes, especially martial infidelity?";
		yes = new MegaeraPunishYes();
		_yes = "Megaera";
		_no = "Alecto";
		no = new MegaeraPunishNo();
	}
}


public class MegaeraPunishYes: DialogueState
{
	public MegaeraPunishYes()
	{
		question = "Yes it is me, Megaera, watch out for me I am the jealous Fury, you don’t want to upset me with your unfaithfulness… Tell me, who punishes for moral crimes of humans, such as anger?";
		yes = new AlectoPunishYes();
		_yes = "Alecto";
		_no = "Tisiphone";
		no = new AlectoPunishNo();
		//jealousy.enabled = false;
	}
}

public class MegaeraPunishNo: DialogueState
{
	public MegaeraPunishNo()
	{
		question = "Wow. No, Alecto doesn't know how to properly do that. I am Megaera. Also known as the Fury of Jealousy...You better not dissapoint me. EVER. Tell me, Tell me, who punishes for moral crimes of humans, such as anger?";
		yes = new AlectoPunishYes();
		_yes = "Alecto";
		_no = "Tisiphone";
		no = new AlectoPunishNo();
		//jealousy.enabled = false;
	}
}

public class AlectoPunishYes : DialogueState
{
	public AlectoPunishYes()
	{
		question = "Watch out for your wrong-doings, I will bring torture into your life. Hi, I’m Alecto, unceasing in anger…Do you think you are willing to disappoint us?";
		yes = new DisappointNo();
		_yes = "No";
		_no = "No";
		no = new DisappointNo();
	}
}

public class AlectoPunishNo: DialogueState
{
	public AlectoPunishNo()
	{
		question = "COME ON. She literally just told you that she punishes for murder. I am Alecto, your moral crimes won't go pass me...Do you think you are willing to disappoint us?";
		yes = new DisappointNo();
		_yes = "No";
		_no = "No";
		no = new DisappointNo();
	}
}

public class DisappointNo: DialogueState
{
	public DisappointNo()
	{
		question = "Good. However, we will be the Judges of that. Now. You and your partner are lost in the forest. Do you help them when they feel tired?";
		yes = new TiredYes();
		no = new GameOverState();
	}
}

public class TiredYes: DialogueState
{
	public TiredYes()
	{
		question = "They appreciate your help. As you keep on walking you find out you have one last sip of water left. Do you give it to your partner?";
		yes = new WaterYes();
		no = new GameOverState();
	}
}


public class WaterYes: DialogueState
{
	public WaterYes()
	{
		question = "I see you're a good soldier. It is now night time, so you decide to have some rest. Your partern falls asleep first. But you look up and realise that infront of you is the person of your dreams. Your partner won't wake up, they're dead asleep. And will never find out if you had something with the person standing infront. Do you decide to spend some time with them?";
		yes = new SpendTimeNobutYes();
		no = new GameOverState();
	}
}

public class SpendTimeNobutYes: DialogueState
{
	public SpendTimeNobutYes()
	{
		question = "I see your quite loyal. Next thing you know, that person charges at you and tell you that they want to be with you and no one else. They're quite aggressive. What do you do? ";
		yes = new GameOverT ();
		_yes = "Kill";
		_no = "Just have fun";
		no = new GameOverM();
	}
}


public class GameOverState: DialogueState
{
	public GameOverState()
	{
//		calmModeImage.image  
		question = "GAME OVER /n Do you want to try again?";
		yes = null;
		no = null;
	}
}

public class GameOverT: DialogueState
{
	public GameOverT()
	{
		//		calmModeImage.image  
		question = "GAME OVER /n I told you. I will get to you. /n Do you want to try again?";
		yes = null;
		no = null;
	}
}
public class GameOverM: DialogueState
{
	public GameOverM()
	{
		//		calmModeImage.image  
		question = "GAME OVER /n YOU ARE DISGUSTING! HOW COULD YOU! /n Do you want to try again?";
		yes = null;
		no = null;
	}
}
public class GameOverA: DialogueState
{
	public GameOverA()
	{
		//		calmModeImage.image  
		question = "GAME OVER /n I hope you suffer... /n Do you want to try again?";
		yes = null;
		no = null;
	}
}




public class CalmImage: DialogueState
{
	public CalmImage()
	{
		
	}
}
